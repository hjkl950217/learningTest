using System.Collections.Generic;
using System.Linq;

namespace 技术点验证
{
    /// <summary>
    /// 将要注册为学生的数据<para></para>
    /// PS:主要是命名空间下有下Student了，但作用不一样，不能复用，所以改了下名字
    /// </summary>
    public class PreStudent : ValueObjectBase<PreStudent>
    {
        public PreStudent(PreStudent data) : base(data)
        {
        }

        /// <summary>
        /// Pre学生ID
        /// </summary>
        public int StudentID { get; set; }

        /// <summary>
        /// 班级信息-模拟值类型值对象
        /// </summary>
        public Value<string> Name { get; set; }

        /// <summary>
        /// 班级信息-模拟引用类型值对象
        /// </summary>
        /// <remarks>
        /// 模拟嵌套的情况
        /// </remarks>
        public ValueObject<List<ValueObject<StuClassInfo>>> ClassInfos { get; set; }

        /// <summary>
        /// 消息-模拟传统属性
        /// </summary>
        public Msg_Entity Msg { get; set; }

        public override bool BizCheckValue()
        {
            return this.StudentID > 0
                && this.Msg != null//模拟实体类的业务规则，这里只是不可空
                && !this.ClassInfos.Value.Any(t => t.Value.ClassName.Value == this.Name.Value);//模拟业务规则，这里是学员姓名不能与任何一个班级名相等
        }

        protected override IEnumerable<object> GetEqualityComponents(PreStudent value)
        {
            yield return this.StudentID;
            yield return this.Name;

            foreach (object item in this.ClassInfos.Value)//针对数组、集合类型
            {
                yield return item;
            }

            //这里忽略了Msg属性，因为从设计上来说Msg信息与学员是否重复没有关系
        }
    }
}