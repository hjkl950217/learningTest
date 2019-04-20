namespace Verification.Core
{
    /// <summary>
    /// 验证的类型
    /// <para>A：单文件,纯技术点的验证</para>
    /// <para>B：语法、设计思想层面的验证。会有多个文件</para>
    /// </summary>
    public enum VerificationTypeEnum
    {
        #region 技术点

        A01_获取当前路径的方法,
        A02_线程ID验证,
        A03_时间格式验证,
        A04_ConcurrentDictionary的研究,
        A05_EFCore学习,

        /// <summary>
        /// 只用来查看配置与IOC的使用即可
        /// </summary>
        A06_配置与IOC接口,

        A07_动态添加Attribute,
        A08_MessagePack基准测试,
        A09_读取文件并监控变化,
        A10_读取文件到配置系统并监控变化,
        A11_日志系统研究,
        A12_扫描泛型接口,
        A13_Asynclocal的坑,
        A14_查找相同对象的基准测试,
        A15_分割字符串的基准测试,
        A16_懒加载,
        /// <summary>
        /// 用马尔可夫链推测出所有可能的场景
        /// </summary>
        A17_马尔可夫链,
        A18_预测鸢尾花的类型_多类分类,
        A19_熵的计算,

        #endregion 技术点

        #region 语法类

        B01_建造者模式学习,
        B02_用反射设置值,
        B03_协变和逆变,

        /// <summary>
        /// 在C# 7.2版本才有的
        /// </summary>
        B04_具有值类型的引用语义_In_72,

        B05_表达式树研究,
        B06_模式匹配_In_70,
        B07_递归,
        B08_Chsarp中写函数式编程,
        B09_访问者模式,
     

        #endregion 语法类

        ZZZZ_Non
    }
}