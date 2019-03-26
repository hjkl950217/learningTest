namespace 语法验证与学习._B06_模式匹配_In_70_
{
    /// <summary>
    /// 三角形
    /// </summary>
    public class Triangle
    {
        /// <summary>
        /// 底边长
        /// </summary>
        public double BottomEdge { get; }

        /// <summary>
        /// 高
        /// </summary>
        public double Height { get; }

        public Triangle(double bottomEdge, double height)
        {
            this.BottomEdge = bottomEdge;
            this.Height = height;
        }
    }
}