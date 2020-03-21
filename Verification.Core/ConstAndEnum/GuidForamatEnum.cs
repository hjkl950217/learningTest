namespace Verification.Core.ConstAndEnum
{
    /// <summary>
    /// GUID 格式化枚举<para></para>
    /// 描述里'0'代表数字。因为GUID是128位数字，16进制表示，所以都是数字<para></para>
    /// 官方资料：https://docs.microsoft.com/en-us/dotnet/api/system.guid.tostring?view=netframework-4.8#System_Guid_ToString_System_String_
    /// </summary>
    public enum GuidForamatEnum
    {
        /// <summary>
        /// 32位数字.如： '00000000000000000000000000000000'
        /// </summary>
        N,

        /// <summary>
        /// 用连字符分隔的32位数字. 如：'00000000-0000-0000-0000-000000000000'
        /// </summary>
        D,

        /// <summary>
        /// 用连字号分隔的32位数字，并用大括号括起来.如：'{00000000-0000-0000-0000-000000000000}'
        /// </summary>
        B,

        /// <summary>
        /// 用连字符分隔的32位数字，并用括号括起来.如：'(00000000-0000-0000-0000-000000000000)'
        /// </summary>
        P,

        /// <summary>
        /// 用括号括起来的四个十六进制值，其中第四个值也是用括号括起来的八个十六进制值的子集 .如：'{0x00000000,0x0000,0x0000，{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}}'
        /// </summary>
        X,
    }
}