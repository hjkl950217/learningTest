namespace Verification.Core
{
    /// <summary>
    /// 验证的类型
    /// <para>A：单文件,纯技术点的验证</para>
    /// <para>B：语法、设计思想层面的验证。会有多个文件</para>
    /// </summary>
    public enum VerificationTypeEnum
    {
        A1_获取当前路径的方法,
        A2_线程ID验证,
        A3_时间格式验证,
        A4_ConcurrentDictionary的研究,
        A5_EFCore学习,

        /// <summary>
        /// 只用来查看配置与IOC的使用即可
        /// </summary>
        A6_配置与IOC接口,
        A7_动态添加Attribute,
        A8_MessagePack基准测试,

        B1_建造者模式学习,
        B2_类型相关的研究,
        B3_协变和逆变,
        /// <summary>
        /// 在C# 7.2版本才有的
        /// </summary>
        B4_具有值类型的引用语义_In_72,


        ZZZZ_Non
    }
}