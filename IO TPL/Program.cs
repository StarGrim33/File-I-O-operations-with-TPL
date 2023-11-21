namespace IO_TPL
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            string filePath = @"C:\Users\Влад и Аня\Desktop\C# course\File-I-O-operations-with-TPL\example.txt";
            string dataExample = "Vlad from Russia, Vladimir city";

            await FileWriter.WriteFile(filePath, dataExample);
            Task<string> readTask = FileReader.ReadFile(filePath);
            await readTask;

            Console.WriteLine($"File content: {readTask.Result}");
        }
    }
}