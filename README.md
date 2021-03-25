# CkTools

| NuGet | License |
|--|--|
| [![](https://img.shields.io/nuget/v/CkTools.svg)](https://www.nuget.org/packages/CkTools)| [![LICENSE](https://img.shields.io/badge/license-Anti%20996-blue.svg)](https://github.com/996icu/996.ICU/blob/master/LICENSE) |

包括大量扩展方法、工具方法、技术点验证、语法验证、C#以外的资料。

这些库是作者在日常工作中将一些不方便或阅读不顺畅的代码封装后的产物，也是做一个技术点的积累。 但受限作者时间有限，目前代码的更新主要依赖于工作中遇到的(也就是说库里面的代码经过了实践),包含的内容广度还比较低，欢迎广大社区朋友一起贡献。

目录：

[TOC]


# 库介绍

## 核心库
| 包名 | 介绍 |
|---------------------------------|------------------------------------- |
|CkTools                       |包的合集，和一些独特的工具               |
|CkTools.Abstraction           |定义及其公共的代码结构                   |

## 功能库
| 包名 | 介绍 |
|---------------------------------|------------------------------------------------------ |
|CkTools.FP                       |函数式扩展库,目前包括柯里化、管道的扩展。              |
|CkTools.BaseExtensions           |大量基础类型的扩展方法,搬砖利器                        |
|CkTools.Nova           	      |业务中间件库                                     	  |


# 安装程序包
包管理
```shell
PM> Install-Package CkTools 
PM> Install-Package CkTools.Abstraction
PM> Install-Package CkTools.FP
PM> Install-Package CkTools.BaseExtensions
PM> Install-Package CkTools.Nova
```
.Net Cli
```shell
dotnet add package CkTools 
dotnet add package CkTools.Abstraction
dotnet add package CkTools.FP
dotnet add package CkTools.BaseExtensions
```

# 使用文档
欢迎查看[Wiki](https://github.com/hjkl950217/learningTest/wiki)


