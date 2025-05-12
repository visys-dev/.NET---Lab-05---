using System;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks.Task2
{
    // Делегат для callback-функції
    public delegate void DataDownloadedHandler(string data);

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding  = Encoding.UTF8;

            // Запускаємо "завантаження" з імітацією затримки 2 сек
            await DownloadFileAsync("https://example.com/file.txt", CallbackFunction);

            Console.WriteLine("Натисніть Enter для завершення…");
            Console.ReadLine();
        }

        static async Task DownloadFileAsync(string url, DataDownloadedHandler callback)
        {
            await Task.Delay(2000);  // імітація завантаження
            string data = "Отримані дані з веб-сервісу";
            callback(data);
        }

        static void CallbackFunction(string data)
        {
            Console.WriteLine("Дані успішно завантажено:");
            Console.WriteLine(data);
        }
    }
}