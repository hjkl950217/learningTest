namespace System
{
    public static class GuidExtensions
    {
        /// <summary>
        /// 转换为JAVA中UUID的模式
        /// </summary>
        /// <param name="guid"></param>
        /// <remarks>
        /// 格式化资料：https://docs.microsoft.com/en-us/dotnet/api/system.guid.tostring?view=netcore-3.1#System_Guid_ToString_System_String_
        /// </remarks>
        /// <returns></returns>
        public static string ToUUID(this Guid guid)
        {
            return guid.ToString("N");
        }
    }
}