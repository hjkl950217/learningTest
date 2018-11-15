
# Nova文档

[toc]

## 这是什么库？有什么用？为什么要取这个名字？
**关于有什么用**：**Nova**是帮助你在业务开发中使用各种设计模式、设计思想的库。在软件开发中有各种设计模式和设计思想,甚至还可以应用其它领域的知识理论（比如管理领域中的建模）。而在我们业务开发中要使用这些东西，必然涉及到学习成本，而想要好的把这些东西组合在业务中是一件比较费脑\麻烦的事。Nova正是为解决这个问题而开发的。

**关于名字**：最开始我编写时只是想把**中间件思想**带入我们业务开发中，在2个业务中尝试后，已经有一个初步的模型了。在把这个模型实现成库后，我觉得以后把一些先进理论整合起来，并且降低脑力消耗和代码编写（要优化设计，代码量必然上升）。在暴雪爸爸的**星际争霸2**中，**诺娃**是一个幽灵的角色，而在我的设想中，也想让开发人员神不知鬼不觉的用上这些好东西，那幽灵就可以很好的表达这种了。。

## 如何使用？

Nuget中引入包之后，只需要要阅读本文档，明确每块代码的**作用\背景\适合**的问题，即可上手了。在代码编写中我会在各种可调用的东西上面写好**注释**。这些注释在简单的表述后，还有**备注**哦！一般我会在备注中留下引导性的东西。让你可以**快速上手**使用。

## 1.业务逻辑中使用中间件

在.net core中，引入了**中间件思想**，而这个思想也不是什么高级的东西，业界中早有了，但一直没有在业务开发中使用的。核心思想就是**管道式**，代码流程走到中间时不用考虑前后，只用考虑当前的情况就好了。（业务中有上下文要求的除外）

**下面以测试用的代码介绍。**

引入包后，在注册服务的地方中注册服务。
``` csharp

            services.AddNova();

```

然后设计你的业务上下文对象和步骤枚举
``` csharp

    public class TestResult//上下文对象 存放处理用到的数据
    {
        public int ID { get; set; }
        public string Message { get; set; }
    }
    
    public enum TestTaskEnum//步骤枚举 用来查看步骤
    {
        Start = 1,
        End = 50,
        EndLog = 100
    }

```
目前这个对象需要包含：
1.  运行业务逻辑需要的起始数据
2.  处理完成后返回结果类型，初始化这个返回结果。

然后编写步骤类。这一步有**约定**在里面！
``` csharp
   [NovaRegister(TestTaskEnum.Start, typeof(TestResult))]//打上标记才能让框架识别哦
    public class Test_A_Step : ITask//需要实现这个接口
    {
        private readonly TestConfig testConfig;

        public Test_C_Step(TestConfig testConfig)//这是从IOC中获取的数据
        {
            this.testConfig = testConfig;
        }
        
        public ITask Next { get; set; }//代表下一步

        //实现ITask接口的方法，代表你在这一步中需要的操作
        public Task InvokeAsync(TaskContext context)
        {
            var conText2 = context.GetGenericContext<TestResult>();
            //todo... 模拟自己的操作
            
            var endTask = this.Next.InvokeAsync(conText2);//调用下一步
            
            //todo... 模拟上一步完成后自己的操作
            return endTask;
        }
    }

```

这里的约定：
1.  需要打上标签，框架才能识别到。第一个参数框架会使用，代表你的业务步骤。第二个参数目前不会使用，代表你的上下文对象。
2.  InvokeAsync方法参数为**TaskContext** ，但是这在业务开发中会比较麻烦。所以设计了一个泛型的 **TaskContext<TResult>**。在调用第一步时，需要自己初始化返回数据的引用。因为**TaskContext<TestResult>** 的**Result**属性初始类型为Object；
3.  需要手动调用**this.Next.InvokeAsync**方法。需要需要用到**上下文数据**，还需要用**GetGenericContext**转换一下。


最后就是调用了，比较简单：

``` csharp
				//取得第一个可执行的中间件
                ITask testTask = di
                    .GetService<INovaFactory>()
                    .GetFirstTask<TestTaskEnum>();
                    
                //初始化上下文对象
                TestResult testContext = new TestResult()
                {
                    ID = expectID,
                };
                TaskContext<TestResult> taskContext = TaskContext.CreateContext(testContext);
               
                //执行
               await ITask.InvokeAsync(taskContext );

                //取出数据
                taskContext.ResultEntiy

```

1.   第一步：这一步是取出第一个可执行的中间件，后面的步骤都关联在Next属性上了。在实际开发中，这个代码应该在构造方法中，通过参数获取INovaFactory。
2.   第二步： 目前需要手动初始化上下文对象和结果数据的引用。
3.   第三步：就是等待执行。
4.   第四步： 手动取出数据