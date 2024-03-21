using System.Text;

namespace FormGetCDK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            this.InitializeComponent();
        }

        private static readonly string[] separator = new string[] { "\t", " " };

        #region ������ť-����¼�

        private void button1_Click(object sender, EventArgs e)
        {
            #region ��ȡ

            string[] contentList = this.textBox1.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            contentList = contentList.Where(t => !string.IsNullOrEmpty(t)).ToArray();

            #endregion ��ȡ

            #region ����

            List<string> resultList = [];
            foreach(string line in contentList)
            {
                IEnumerable<string> lineStrs = line
                    .Split(separator, StringSplitOptions.None)
                    .Where(t => !string.IsNullOrEmpty(t))
                    .Select(t => t.Trim())
                    .Skip(1);//�𿪺��1�������ƣ���2������CDK

                foreach(var lineStr in lineStrs)
                {
                    if(char.IsAscii(lineStr[0]))
                    {
                        resultList.Add(lineStr);
                        break;
                    }
                }
            }

            #endregion ����

            this.textBox2.Text = string.Join("\r\n", resultList);
        }

        #endregion ������ť-����¼�

        #region ����CDK��ť-����¼�

        private void button2_Click(object sender, EventArgs e)
        {
            #region ��ȡ�ļ���ַ

            string[] fileNames = Array.Empty<string>();
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Multiselect = true;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNames = openFileDialog.FileNames;
                // ������Դ���ѡ�е��ļ�
            }

            if(fileNames == null || fileNames.Length == 0)
            {
                return;
            }

            #endregion ��ȡ�ļ���ַ

            // ��ȡĿ¼�����е�txt�ļ������ж�ȡ
            List<string> lines = ReadLinesFromTxtFiles(fileNames);

            // ������õ�Listд��������Ŀ¼�£��ļ�����ʱ�����д��һ��txt�ļ�������д��
            string? exePath = Path.GetDirectoryName(fileNames[0]);
            var sortCdkResult = WriteLinesToTxtFile(lines, exePath);

            // ��ʾ��ʾ��Ϣ
            this.textBox2.Text = $"������ɣ��ļ���ַ:{Environment.NewLine}{Path.GetFullPath(sortCdkResult)}";
        }

        private static List<string> ReadLinesFromTxtFiles(string[] fileNames)
        {
            List<string> lines = new(128);
            foreach(var fileName in fileNames)
            {
                foreach(var fileLine in File.ReadLines(fileName, Encoding.GetEncoding("GB18030")))
                {
                    if(string.IsNullOrEmpty(fileLine)
                        || fileLine.Contains("״̬"))
                    {
                        continue;
                    }

                    lines.Add(fileLine.Trim());
                }
            }

            lines.Sort();// ����
            return lines.Distinct().ToList();
        }

        private static string WriteLinesToTxtFile(List<string> lines, string? directoryPath)
        {
            //�жϵ�ַ�Ƿ����
            if(!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            //д���ļ�
            string fileName = $"�ι�������_{DateTime.Now:yyyyMMddHHmmss}.txt";
            string filePath = Path.Combine(directoryPath, fileName);
            File.WriteAllLines(filePath, lines, Encoding.GetEncoding("GB18030"));
            return filePath;
        }

        #endregion ����CDK��ť-����¼�
    }
}