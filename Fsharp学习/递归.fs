module Fsharp学习.递归

open System

///演示递归
let showRecursiveFunctions=

    //处理元素的集合或序列通常是通过F＃中的递归来完成的。
    //尽管F＃支持循环和命令式编程，但首选递归，因为它更容易保证正确性。

    printfn "演示---递归"
    ///阶乘
    let rec factortial n =
        if n=0 then 1 //在n=0时跳出 0的乘为1
        else n*factortial(n-1)

    printfn "%d的阶乘:%d" 6 (factortial(6))

    ///计算2个数的最大公因数
    //由于所有递归调用都是尾调用，因此编译器会将函数转换为循环，从而提高了性能并减少了内存消耗。
    let rec greatestCommonFactor a b =
          if a = 0 then b
          elif a < b then greatestCommonFactor a (b - a)
          else greatestCommonFactor (a - b) b