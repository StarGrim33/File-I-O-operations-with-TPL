using System;

namespace IO_TPL
{
    public class FileWriter
    {
        public static async Task WriteFile(string filePath, string data)
        {
            using StreamWriter writer = new(filePath);
            await writer.WriteAsync(data);
            Console.WriteLine("File written");
        }
    }

    public class FileReader
    {
        public static async Task<string> ReadFile(string filePath)
        {
            using StreamReader reader = new(filePath);
            string content = await reader.ReadToEndAsync();
            return content;
        }
    }
}
