//using Microsoft.Extensions.DependencyInjection;
//using NSubstitute;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Xunit;

//namespace LogicalChain.Test
//{
//    [Trait("Category","TaskMwHelper")]
//    public class TaskMwHelperTest
//    {
//        #region 准备数据

//        //public class TaskTestEntity
//        //{
//        //    public string Name { get; set; }
//        //}

//        public class TestContext : TaskContextBase<string>
//        {
//            public bool ProcessCompleted
//            {
//                get => throw new NotImplementedException();
//                set => throw new NotImplementedException();
//            }

//            public List<TaskError> ErrorList => throw new NotImplementedException();

//            public string Result => "NotImplemented";

//            public override TResult GetResult<TResult>()
//            {
//                throw new NotImplementedException();
//            }
//        }

//        internal class TestTaskA : ITask
//        {
//            public ITask Next { get; set; }

//            public int ExecuteOrder => 1;

//            public Task<TResult> InvokeAsync<TResult>(TaskContextBase<TResult> context)
//            {
//                return this.Next.InvokeAsync(context);
//            }
//        }

//        internal class TestTaskB : ITask
//        {
//            public ITask Next { get; set; }

//            public int ExecuteOrder => 10;

//            public Task<TResult> InvokeAsync<TResult>(TaskContextBase<TResult> context)
//            {
//                return this.Next.InvokeAsync(context);
//            }
//        }

//        private static class MockHelp
//        {
//            /// <summary>
//            ///
//            /// </summary>
//            /// <param name="di">传递时会从DI中获取</param>
//            /// <returns></returns>
//            public static IReadOnlyList<ITask> GetMockMwList(IServiceProvider di = null)
//            {
//                List<ITask> taskList = new List<ITask>();

//                if(di == null)
//                {
//                    taskList.Add(new TestTaskA());
//                    taskList.Add(new TestTaskB());
//                }
//                else
//                {
//                    var diList = di.GetService<IEnumerable<ITask>>();
//                    taskList.AddRange(diList);
//                }

//                return taskList;
//            }

//            public static IServiceProvider GetMockDi()
//            {
//                var di = new ServiceCollection()
//                    //.AddScoped<ITaskContext<string>,TestContext>()
//                    .AddScoped<TestContext>()
//                    .AddSingleton<ITask,TestTaskA>()
//                    .AddSingleton<ITask,TestTaskB>()
//                    .BuildServiceProvider();

//                return di;
//            }

//            public static ITaskHelper GetTaskHelper()
//            {
//                return new TaskHelper();
//            }
//        }

//        #endregion 准备数据

//        [Fact]
//        public void Tc_Sort_AutoEnd()
//        {
//            var taskList = MockHelp.GetMockMwList();

//            var result = MockHelp.GetTaskHelper().Sort(taskList,false);

//            Assert.Equal(10,result[0].Next.ExecuteOrder);
//            Assert.Equal(10,result[1].ExecuteOrder);
//            Assert.Equal(int.MaxValue,result[1].Next.ExecuteOrder);
//        }

//        [Fact]
//        public void Tc_SortByDi()
//        {
//            var di = MockHelp.GetMockDi();
//            var taskList = MockHelp.GetMockMwList(di);

//            var result = MockHelp.GetTaskHelper().Sort(taskList,true);

//            Assert.Equal(1,result[0].ExecuteOrder);
//            Assert.Equal(10,result[1].ExecuteOrder);
//            Assert.Equal(int.MaxValue,result[1].Next.ExecuteOrder);
//        }

//        [Fact]
//        public void Tc_SortByUse()
//        {
//            var taskList = MockHelp.GetMockDi()
//                .GetService<IEnumerable<ITask>>()
//                .ToList();

//            //这里用Use的方式
//            var result = MockHelp.GetTaskHelper().SortByUse(taskList[1],taskList[0]);
//            Assert.Equal(10,result.ExecuteOrder);

//            var result2 = result.Next;
//            Assert.Equal(1,result2.ExecuteOrder);
//            Assert.Null(result2.Next);
//        }

//        [Fact]
//        public void Test()
//        {
//            var taskList = MockHelp.GetMockDi()
//                .GetService<TestContext>();
//        }

//        public class ttttt
//        {
//            public ITask GetTask<TContext>()
//            {
//                return null;
//            }

//            public void Test()
//            {
//                ITask taskMw = this.GetTask<TestContext>();
//                taskMw.InvokeAsync(new TestContext());
//            }
//        }
//    }
//}