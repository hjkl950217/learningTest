module Fsharp学习.基础

open System

///演示递归
let showBasic=

    let function1 x = x + 1
    let function2 x = x * 2
    let h = function1 >> function2

    printfn "演示-函数组成"
    printfn "用>>符号"
    printfn "let function1 x = x + 1"
    printfn "let function2 x = x * 2"
    printfn "let h = function1 >> function2"

    let fun1 g a = g (g a) //f(g,a) = g(g(a))
    let fun2 g a = g(a |> g) //f(g,a) = g(g(a))

    printfn "演示-高阶函数"
    printfn "定义的函数为:f(g,a) = g(g(a))"
    printfn "普通写法:    let fun1 g a = g (g a)"
    printfn "管道式写法:  let fun2 g a = g a |> g   或   let fun2 g a = g(a |> g)"

    let add x y= x + y
    let one = 1
    let add1 (x:int) = add x one

    printfn "演示-柯里化"
    printfn "基础函数:          let add x y= x + y"
    printfn "1的常量表达式:     let one =1"
    printfn "柯里化1：          let add1 (x:int) = add one  //在使用时 x会传递给add函数的第2个参数"
    printfn "柯里化2：          let add1 (x:int) = add x one  //在使用时 x会传递给add函数的第1个参数"