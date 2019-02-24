using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Colore;
using Colore.Data;
using Newtonsoft.Json;
using KeyCode = Colore.Effects.Keyboard.Key;

namespace chroma_plugin
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => StartRestApp());
            Console.ReadLine();
        }

        private static async void StartRestApp()
        {
            // When creating a Chroma instance using the REST API backend, you need to supply the SDK with information about your app.
            var appInfo = new AppInfo("Another App", "Another awesome Chroma app!", "Test Test", "test@example.com", Category.Application);

            IChroma chroma = await ColoreProvider.CreateRestAsync(appInfo);

            Console.WriteLine(chroma.Initialized);
        }
    }
}


        // private static async void StartNativeApp()
        // {
        //     IChroma chroma = await ColoreProvider.CreateNativeAsync();
        //     Console.WriteLine(chroma.Initialized);

        //     for (int i = 0; i < 50; i++)
        //     {
        //         await chroma.Keyboard.SetKeyAsync(KeyCode.Space, Color.Green);    
        //     }
        // }
