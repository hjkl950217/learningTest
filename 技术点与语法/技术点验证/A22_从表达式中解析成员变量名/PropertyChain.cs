﻿using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reflection;

namespace 技术点验证
{
    /// <summary>
    /// Represents a chain of properties
    /// </summary>
    public class PropertyChain
    {
        public static string? PropertyChainSeparator = ".";

        private readonly List<string?> _memberNames = new List<string?>(2);

        /// <summary>
        /// Creates a new PropertyChain.
        /// </summary>
        public PropertyChain()
        {
        }

        /// <summary>
        /// Creates a new PropertyChain based on another.
        /// </summary>
        public PropertyChain(PropertyChain parent)
        {
            if(parent != null
                && parent._memberNames.Count > 0)
            {
                this._memberNames.AddRange(parent._memberNames);
            }
        }

        /// <summary>
        /// Creates a new PropertyChain
        /// </summary>
        /// <param name="memberNames"></param>
        public PropertyChain(IEnumerable<string?> memberNames)
        {
            this._memberNames.AddRange(memberNames);
        }

        /// <summary>
        /// Creates a PropertyChain from a lambda expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static PropertyChain FromExpression(LambdaExpression expression)
        {
            Stack<string> memberNames = new Stack<string>();

            Func<Expression, MemberExpression?> getMemberExp = new Func<Expression, MemberExpression?>(toUnwrap =>
            {
                if(toUnwrap is UnaryExpression)
                {
                    return ((UnaryExpression)toUnwrap).Operand as MemberExpression;
                }

                return toUnwrap as MemberExpression;
            });

            MemberExpression? memberExp = getMemberExp(expression.Body);

            while(memberExp != null)
            {
                memberNames.Push(memberExp.Member.Name);
                memberExp = getMemberExp(memberExp.Expression);
            }

            return new PropertyChain(memberNames);
        }

        /// <summary>
        /// Adds a MemberInfo instance to the chain
        /// </summary>
        /// <param name="member">Member to add</param>
        public void Add(MemberInfo member)
        {
            if(member != null)
                this._memberNames.Add(member.Name);
        }

        /// <summary>
        /// Adds a property name to the chain
        /// </summary>
        /// <param name="propertyName">Name of the property to add</param>
        public void Add(string? propertyName)
        {
            if(!string.IsNullOrEmpty(propertyName))
                this._memberNames.Add(propertyName);
        }

        /// <summary>
        /// Adds an indexer to the property chain. For example, if the following chain has been constructed:
        /// Parent.Child
        /// then calling AddIndexer(0) would convert this to:
        /// Parent.Child[0]
        /// </summary>
        /// <param name="indexer"></param>
        /// <param name="surroundWithBrackets">Whether square brackets should be applied before and after the indexer. Default true.</param>
        public void AddIndexer(object indexer, bool surroundWithBrackets = true)
        {
            if(this._memberNames.Count == 0)
            {
                throw new InvalidOperationException("Could not apply an Indexer because the property chain is empty.");
            }

            string? last = this._memberNames[this._memberNames.Count - 1];
            last += surroundWithBrackets ? "[" + indexer + "]" : indexer;

            this._memberNames[this._memberNames.Count - 1] = last;
        }

        /// <summary>
        /// Creates a string? representation of a property chain.
        /// </summary>
        public override string? ToString()
        {
            // Performance: Calling string?.Join causes much overhead when it's not needed.
            //return this._memberNames.Count switch
            //{
            //    0 => string.Empty,
            //    1 => this._memberNames[0],
            //    _ => string.Join(PropertyChain.PropertyChainSeparator, this._memberNames),
            //};

            return this._memberNames.Count switch
            {
                0 => string.Empty,
                _ => string.Join(PropertyChain.PropertyChainSeparator, this._memberNames)
            };
        }

        /// <summary>
        /// Checks if the current chain is the child of another chain.
        /// For example, if chain1 were for "Parent.Child" and chain2 were for "Parent.Child.GrandChild" then
        /// chain2.IsChildChainOf(chain1) would be true.
        /// </summary>
        /// <param name="parentChain">The parent chain to compare</param>
        /// <returns>True if the current chain is the child of the other chain, otherwise false</returns>
        public bool IsChildChainOf([NotNull] PropertyChain parentChain)
        {
            return (this.ToString() ?? string.Empty).StartsWith(parentChain.ToString() ?? string.Empty);
        }

        /// <summary>
        /// Builds a property path.
        /// </summary>
        public string? BuildPropertyName(string? propertyName)
        {
            if(this._memberNames.Count == 0)
            {
                return propertyName;
            }

            PropertyChain chain = new PropertyChain(this);
            chain.Add(propertyName);
            return chain.ToString();
        }

        /// <summary>
        /// Number of member names in the chain
        /// </summary>
        public int Count => this._memberNames.Count;
    }
}