public class Program
{
    private static void Main(string[] args)
    {
        string folderPath = @"E:\公司\成都-鸿翼医药\V5"; // 替换为您要扫描的文件夹路径

        string[] includePatterns = { "obj", "bin" };

        string[] directories = Directory
            .GetDirectories(folderPath, "*", SearchOption.AllDirectories)
            .Where(t => includePatterns.Any(p => IsMatch(t, p)))
            .ToArray();

        foreach(string directory in directories)
        {
            Directory.Delete(directory, true); // 删除文件夹及其所有内容
            Console.WriteLine("删除文件夹: " + directory); // 输出已删除的文件夹名
        }

        Console.WriteLine($"完成，删除了{directories.Length}个文件夹");
        Console.ReadLine();
    }

    public static bool IsMatch(string str, string matchStr)
    {
        return str.EndsWith(matchStr);
    }
}