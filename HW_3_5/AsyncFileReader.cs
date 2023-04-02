using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_5
{
    public class AsyncFileReader
    {
        public async Task<string> ReadFromFileAsync(string filePath)
        {
            using var reader = new StreamReader(filePath);
            return await reader.ReadToEndAsync();
        }

        public async Task<string> FetchTextAsync()
        {
            var helloTask = ReadFromFileAsync("Hello.txt");
            var worldTask = ReadFromFileAsync("World.txt");

            await Task.WhenAll(helloTask, worldTask);

            return string.Concat(await helloTask, await worldTask);
        }
    }

}

