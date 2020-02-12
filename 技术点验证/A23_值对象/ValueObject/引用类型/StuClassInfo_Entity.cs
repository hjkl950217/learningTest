namespace 技术点验证
{
    /// <summary>
    /// 学生课程实体(结构)
    /// </summary>
    public class StuClassInfo_Entity
    {
        /// <summary>
        /// 课程ID
        /// </summary>
        public int ClassID { get; set; }

        /// <summary>
        /// 课程名字
        /// </summary>
        /// <remarks>
        /// 如果这里想对ClassName做长度限制，就需要用专门的ClassName值对象
        /// </remarks>
        public Value<string> ClassName { get; set; }
    }
}