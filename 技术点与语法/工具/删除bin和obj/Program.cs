public class Program
{
    private static void Main(string[] args)
    {
        string folderPath = @"E:\个人\learningTest\技术点与语法";

        string[] includePatterns = { "obj", "bin" };

        string[] directories = Directory
            .GetDirectories(folderPath, "*bin", SearchOption.AllDirectories)
            .Concat(Directory
                .GetDirectories(folderPath, "*obj", SearchOption.AllDirectories))
            .Where(t => includePatterns.Any(p => t.EndsWith(p)))
            .ToArray();

        foreach(string directory in directories)
        {
            Directory.Delete(directory, true); // 删除文件夹及其所有内容
            Console.WriteLine("删除文件夹: " + directory); // 输出已删除的文件夹名
        }

        Console.WriteLine($"完成，删除了{directories.Length}个文件夹");
        Console.ReadLine();
    }
}