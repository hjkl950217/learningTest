namespace 语法验证与学习
{
    public class TwoValueEntityComparer : TwoValueComparer<TwoValueEntity, string, int>
    {
        public TwoValueEntityComparer()
            : base(t => t.Name, t => t.ID)
        {
        }
    }
}