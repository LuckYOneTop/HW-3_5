namespace HW_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var asyncFileReader = new AsyncFileReader();
            var result = asyncFileReader.FetchTextAsync().Result;
        }
    }
}