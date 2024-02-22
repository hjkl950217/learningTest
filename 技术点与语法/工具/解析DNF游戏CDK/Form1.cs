namespace FormGetCDK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 读取

            string[] contentList = this.textBox1.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            contentList = contentList.Where(t => !string.IsNullOrEmpty(t)).ToArray();

            #endregion 读取

            #region 解析

            List<string> resultList = [];
            foreach(string line in contentList)
            {
                IEnumerable<string> lineStrs = line
                    .Split("\t").Where(t => !string.IsNullOrEmpty(t))
                    .Skip(1);

                foreach(var lineStr in lineStrs)
                {
                    if(char.IsAscii(lineStr[0]))
                    {
                        resultList.Add(lineStr);
                        break;
                    }
                }
            }

            #endregion 解析

            this.textBox2.Text = string.Join("\r\n", resultList);
        }
    }
}