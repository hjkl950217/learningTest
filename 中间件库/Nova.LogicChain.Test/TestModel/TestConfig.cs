namespace Nova.LogicalChain.Test
{
    /// <summary>
    /// 模拟实现需要从外部获取的配置类
    /// </summary>
    public class TestConfig
    {
        public bool IsRelease { get; set; }

        public string ServiceName { get; set; }
    }
}