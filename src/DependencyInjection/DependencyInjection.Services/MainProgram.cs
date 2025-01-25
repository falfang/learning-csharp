using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Services
{
    /// <summary>
    /// メインプログラム
    /// </summary>
    internal class MainProgram
    {
        /// <summary>
        /// メイン関数
        /// </summary>
        /// <param name="args">メイン関数引数</param>
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IDataService, DataService>()
                .AddTransient<DataProcessor>()
                .BuildServiceProvider();

            var processor = serviceProvider.GetRequiredService<DataProcessor>();
            Console.WriteLine("Process string data: " + processor.ProcessStringData("abc"));
            Console.WriteLine("Process int data   : " + processor.ProcessIntData(42));
        }
    }
}
