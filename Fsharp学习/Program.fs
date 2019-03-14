// Learn more about F# at http://fsharp.org

open System

let sign num=
    if num>0 then "positive"
    elif num <0 then "negative"
    else "zero"

[<EntryPoint>]
let main argv =

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

    Console.ReadLine();
    0 // return an integer exit code