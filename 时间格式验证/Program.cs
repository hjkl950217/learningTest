using System;
using System.Collections.Generic;

namespace 时间格式验证
{
    internal class Program
    {
        private static void Main( string[ ] args )
        {
            /*参考资料-datetime tostring中自定义的格式资料
             * https://docs.microsoft.com/zh-cn/dotnet/standard/base-types/custom-date-and-time-format-strings
             */
            Console.WriteLine( "Task Start\r\n" );
            List<object> outputList = new List<object>( );

            string dt1 = DateTime.Now.ToString( "o" );
            string dt2 = DateTime.Now.ToString( "yyyy-MM-ddTHH:mm:sszzz" );

            //unix时间戳
            long dt3 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds( );

            //输出
            outputList.Add( dt1 );
            outputList.Add( dt2 );
            outputList.Add( dt3 );

            int index = 1;
            foreach( var item in outputList )
            {
                Console.WriteLine( $"第{index++}个" );
                Console.WriteLine( item );
                Console.WriteLine( "-----" );
            }

            Console.WriteLine( "----------------------" );

            //转换回去
            outputList.Clear( );
            index = 1;
            DateTime dt10 = Convert.ToDateTime( dt1 );
            DateTime dt20 = Convert.ToDateTime( dt2 );
            DateTime dt30 = DateTimeOffset.FromUnixTimeMilliseconds( dt3 ).DateTime.AddHours( 8 );

            outputList.Add( dt10 );
            outputList.Add( dt20 );
            outputList.Add( dt30 );
            foreach( var item in outputList )
            {
                Console.WriteLine( $"第{index++}个" );
                Console.WriteLine( item );
                Console.WriteLine( "-----" );
            }

            Console.WriteLine( "Task End" );
            Console.ReadLine( );
        }
    }
}