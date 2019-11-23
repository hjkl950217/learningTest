namespace 语法验证与学习
{
    public class TwoValueEntity
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public override int GetHashCode()
        {
            int code = base.GetHashCode();

            System.Console.WriteLine($"[{this.Name}----{this.ID}----{code}]");

            return code;
        }
    }
}