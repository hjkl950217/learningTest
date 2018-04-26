// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestEnum.cs" company="Newegg" Author="lw47">
//   Copyright (c) 2018 Newegg.inc. All rights reserved.
// </copyright>
// <summary>
//   TestEnum created at  4/13/2018 3:47:13 PM
// </summary>
//<Description>
//
//</Description>
// --------------------------------------------------------------------------------------------------------------------
//向星辰大海前进！

using System.ComponentModel;
using System.Runtime.Serialization;

namespace ManufacturerReuqestSubscriber.Model
{
    /// <summary>
    /// 测试枚举
    /// </summary>
    public enum TestEnum
    {
        [Description("Approve")]
        [EnumMember(Value = "A")]
        Approve = 'A',
        Delete = 'D'
    }
}