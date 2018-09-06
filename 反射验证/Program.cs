//using System;
//using System.Linq;
//using System.Reflection;

//namespace 类型相关的研究
//{
//    public static class Test
//    {
//        public static A A { get; set; } = new A( );
//        public static string XXX { get; set; } = "default";
//    }

//    //大类
//    public  class A
//    {
//        public B BBB { get; set; } = new B( );
//    }

//    //小类
//    public  class B
//    {
//        public string Data { get; set; } = "原始数据";
//    }

//    public static class Ext
//    {
//        public static void GetDataOnWatch<TSystemName, TConfigName>(
//             string data
//             , string systemName = null
//             , string configName = null

//             )
//             where TSystemName : class
//             where TConfigName : class
//        {

//            if( systemName == null ) systemName = typeof( TSystemName ).Name;
//            if( configName == null ) configName = typeof( TConfigName ).Name;


//            //取A的信息
//            var sysObj = typeof( Test )
//                .GetProperties(  )
//                .Where( t => t.PropertyType == typeof( TSystemName ) )
//                .FirstOrDefault( );

//            var tttt = sysObj.GetValue( null );



//            //取B的信息
//            var confObj = sysObj?.PropertyType
//                .GetProperties( )
//                .Where( t => t.PropertyType == typeof( TConfigName ) )
//                .FirstOrDefault( );


//            //从上面A中取数据
//            //var tttt2 = confObj.GetValue( tttt ) as B;
//            // tttt2.Data = "ABC";

//            //从其他A的实例中取数据
//            // var tttt2 = confObj.GetValue( new A( ) { BBB=new B { Data="新数据"} } ) as B;


//            //这个就会失败,传递的必须是confObj.ReflectedType里面的类型
//            //var tttt2 = confObj.GetValue(   new B { Data = "新数据" }  ) ;

//            /*原因：
//            PropertyInfo
//            返回指定对象的属性值
//            */

//            //取具体数据
//            var battributes = confObj.PropertyType
//                .GetProperties( )
//                .Where( t => t.PropertyType == typeof( string ) )
//                .First( );




//            //测试赋值
//            //B bbb = new B( ) ;
//            //battributes.GetValue( bbb );
//            //battributes.SetValue( bbb , "testtet" );

//            //测试把A下面的B修改了
//            var tttt2 = confObj.GetValue( tttt ) as B;
//             B newB = new B( ) { Data = $"{  tttt2.Data }++{data}" };
//            confObj.SetValue( tttt , newB );//参数1是上层数据，参数2是要修改的数据


//        }



//    }

//    internal class Program
//    {
//        private static void Main( string[ ] args )
//        {
//            Console.WriteLine(Test.A.BBB.Data );
//            Console.WriteLine("开始测试");

//            string inPut = "";
//            while( inPut!="2" )
//            {
//                string tempIn = Console.ReadLine();

//                Ext.GetDataOnWatch<A , B>( tempIn );

//                Console.WriteLine("触发一次后的结果");
//                Console.WriteLine( Test.A.BBB.Data );

//            }

//            Console.WriteLine("验证结束");
//            Console.ReadLine( );

//        }
//    }
//}