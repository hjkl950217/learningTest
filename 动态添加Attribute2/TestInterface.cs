namespace 动态添加Attribute2
{
    public interface TestInterface
    {
        [Test(Name = "添加姓名-接口")]
        void AddName(string name);

        void AddInt(int num);
    }
}