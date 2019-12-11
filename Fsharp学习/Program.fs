 //Learn more about F# at http://fsharp.org
 //微软的文档  https://docs.microsoft.com/en-us/dotnet/fsharp/tour

module File2

open System

let sign num=
    if num>0 then "positive"
    elif num <0 then "negative"
    else "zero"

[<EntryPoint>]
let main argv=

    printfn "演示---循环+元组"
    let sampleNumbers = [ 0 .. 99 ]

    let sampleTableOfSquares = [ for i in 0 .. 99 -> (i, (i*i).ToString()) ]

    // The next line prints a list that includes tuples, using '%A' for generic printing.
    printfn "The table of squares from 0 to 99 is:\n%A" sampleTableOfSquares
    Console.WriteLine();

    printfn "演示---字符串获取值"
    let helloWorld="helloWorld"
   // let substring = helloWorld.Substring(0,6).ToString()
    let substring=helloWorld.[0..6]
    printfn "%s" substring
    Console.WriteLine();

    printfn "演示---元组"
    let tuple1 = (1, 2, 3)//一个简单int元组
    let swapElems (a, b) = (b, a)//一个元组转换函数
    printfn "交换 （1, 20）的结果是 %A" (swapElems (1,20))

    let tuple2=(1,"张三",3.1415)//一个比较复杂的元组
    Printf.printfn "tuple1:%A tuple2:%A" tuple1 tuple2

    //struct元组
    let sampleStructTuple=struct(1,2)

    let convertFromStructTuple (struct(a,b))=(a,b)//把一个结构体元组转换成普通元组
    let convertToStructTuple (a,b)=struct(a,b)

    printfn "struct tuple:%A convert to general tuple:%A"
        sampleStructTuple
        (sampleStructTuple |>convertFromStructTuple)

    Console.WriteLine();

    printfn "演示---管道"
    let isOdd x = x % 2 <> 0//判断是否是奇数
    let square x = x * x
    let addOne x = x + 1

    let numbers = [ 1; 2; 3; 4]

    //定义嵌套式函数
    let spuareOddValueAndAddOneNested values =
        let odds = List.filter isOdd values //过滤掉偶数
        let square = List.map square odds // 对剩余的偶数计算平方
        let result =List.map addOne square
        result

    printfn "原始数据:%A" numbers
    printfn "过滤偶数->平方->每个数加1:%A" (spuareOddValueAndAddOneNested(numbers))

    //下面是管道式
    //第一个是要调用List.filter 然后参数是isOdd这个函数
    //这样组合完后，得到一个新的函数
    let spuareOddValueAndAddOnePipeline values =
        values
        |> List.filter isOdd
        |> List.map square
        |> List.map addOne
    printfn "管道式 过滤偶数->平方->每个数加1:%A" (spuareOddValueAndAddOnePipeline(numbers))

    //下面是合并管道
    let spuareOddValueAndAddOneShortPipleLine values =
        values
        |> List.filter isOdd
        |> List.map (fun x ->  x |> square |> addOne)//给map传递的处理函数 是 合并管道后的处理函数

    printfn "合并管道式 过滤偶数->平方->每个数加1:%A" (spuareOddValueAndAddOneShortPipleLine(numbers))

    Console.WriteLine();

    printfn "演示---列表，数组和序列"

    //List是相同类型元素的有序，不可变的集合。它们是单链接列表，这意味着它们仅用于枚举，但是如果它们很大，则对于随机访问和串联来说是一个糟糕的选择。
    //这与其他流行语言中的列表不同，后者通常不使用单链接列表来表示列表

    let list1=[]
    let list2=[1;2;3]//用分号分割
    let list3=[
        1
        2
        3
    ]

    let numberList=[1..5] //定义1到1000的数组

    //List也可以通过计算生成。 这是包含一年中所有日期的列表。
    let dtToString dt=dt.ToString()

    let format (date:DateTime) = date.ToString("yyyy-MM-dd")

    let dayList=
        [for month in 1 .. 12 do
            for day in 1 .. System.DateTime.DaysInMonth(2019,month) do
                yield new System.DateTime(2019,month,day)|> format]
    printfn "通过循环生成的1年所有日期的集合:%A" dayList
    printfn "集合长度:%d" dayList.Length
    printfn "前5个元素%A" (dayList|> List.take 5)

    //计算可以包括条件。 这是一个包含元组的列表，元组是国际象棋棋盘上黑色正方形的坐标。
    let blackSquares =
        [ for i in 0 .. 7 do
              for j in 0 .. 7 do
                  if (i+j) % 2 = 1 then
                      yield (i, j) ]

    //利用map构建numberList平方后的集合
    let squaresOfNumberList=
        numberList
        |>List.map (fun x->x*x)

    printfn "利用map构建numberList平方后的集合：%A" squaresOfNumberList

    //利用sumBy求和平方后的numberList
    let sumOfSquaresFromNumberList=
        numberList
        |> List.sumBy (fun x->x*x)

    printfn "利用sumBy求和平方后的numberList：%A" sumOfSquaresFromNumberList

    printfn "演示---数组"
    //数组是相同类型元素的固定大小的可变集合。它们支持元素的快速随机访问，并且比F＃列表快，因为它们只是连续的内存块

    let array1=[| |] //空数组
    let array2=[|"张三";"李四"|]// string类型的数组
    let array3=[|1..5|]//构建一个1到5的数组

    //构建一个只包括'张'的数组
    let array4=
        [| for word in array2 do
            if word.Contains("张") then
                word

        |]
    let evenNumbers =Array.init 5 (fun x->x*x) //这是一个由索引初始化的数组，包含从5个偶数。从0开始
    printfn "Array.init初始化数组：%A" evenNumbers
    printfn "Array.init初始化数组的长度：%d" evenNumbers.Length

    let evenNumbersSlise=evenNumbers.[0..2] //从evenNumbers切片。获取索引0到2的数据
    printfn "数组切片：%A" evenNumbersSlise

    array2.[0]<-"张三1" //使用左箭头分配符修改数组中的值
    printfn "修改数组内容后的数组:%A" array2

    let sumOfLengthsOfWords =
          array2
          |> Array.filter (fun x -> x.StartsWith "张")
          |> Array.sumBy (fun x -> x.Length)

    Console.ReadLine() |>ignore;

    0 // return an integer exit code