using System;
using System.Collections.Generic;

namespace CkTools
{
    /// <summary>
    /// 链接Action的对象
    /// </summary>
    public class LinkAction
    {
        public List<Action> Actions { get; set; } = new List<Action>();

        private LinkAction()
        {
        }

        /// <summary>
        /// 创建一个<see cref="LinkAction"/>对象用于开启链接Action
        /// </summary>
        /// <returns></returns>
        public static LinkAction Start()
        {
            return new LinkAction();
        }
    }

    public static class LinkActionExtension
    {
        /// <summary>
        /// 添加一个要执行的Action
        /// </summary>
        /// <param name="linkObj"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static LinkAction Add(this LinkAction linkObj, Action action)
        {
            linkObj.Actions.Add(action);
            return linkObj;
        }

        /// <summary>
        /// 添加一组要执行的Action
        /// </summary>
        /// <param name="linkObj"></param>
        /// <param name="actions"></param>
        /// <returns></returns>
        public static LinkAction AddRange(this LinkAction linkObj, params Action[] actions)
        {
            actions ??= Array.Empty<Action>();
            linkObj.Actions.AddRange(actions);
            return linkObj;
        }

        /// <summary>
        /// 批量执行Action
        /// </summary>
        /// <param name="t"></param>
        public static void BatchRun(this LinkAction t)
        {
            foreach (var item in t.Actions)
            {
                item();//执行示例的委托
                Console.WriteLine("--------------------------------");
                Console.WriteLine(string.Empty);
            }
        }
    }
}