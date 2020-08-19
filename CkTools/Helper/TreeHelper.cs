using System;
using System.Collections.Generic;

namespace CkTools.Helper
{
    public static class TreeHelper
    {
        /// <summary>
        /// 构建为树
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <typeparam name="TId">对象的ID类型</typeparam>
        /// <param name="treeNodes">对象集合</param>
        /// <param name="idGetter">id获取器</param>
        /// <param name="parentIdGetter">父级id获取器</param>
        /// <param name="rootNodeJudge">根节点判断器，如:t=>t.id==null</param>
        /// <param name="nodeProcessor">节点处理器，指示子节点如何与父节点挂钩，如:(p,sub)=>p.Children.Add(sub)</param>
        /// <returns></returns>
        public static List<T> BulidTree<T, TId>(
            IEnumerable<T> treeNodes,
            Func<T, TId> idGetter,
            Func<T, TId> parentIdGetter,
            Func<T, bool> rootNodeJudge,
            Action<T, T> nodeProcessor)
        {
            try
            {
                List<T> trees = new List<T>();

                foreach (T treeNode in treeNodes)
                {
                    if (rootNodeJudge(treeNode))
                    {
                        trees.Add(treeNode);
                    }

                    foreach (T it in treeNodes)
                    {
                        if (object.Equals(parentIdGetter(it), idGetter(treeNode)))
                        {
                            nodeProcessor(treeNode, it);
                        }
                    }
                }
                return trees;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}