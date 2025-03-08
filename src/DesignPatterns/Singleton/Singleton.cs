using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample
{
    internal class Singleton
    {
        /// <summary>
        /// シングルトンインスタンス
        /// </summary>
        private static Singleton _instance = new Singleton();

        /// <summary>
        /// Constructor
        /// </summary>
        private Singleton()
        {
            Console.WriteLine("インスタンスを生成しました");
        }

        /// <summary>
        /// インスタンス取得
        /// </summary>
        /// <returns></returns>
        public static Singleton GetSingleton()
        {
            return _instance;
        }
    }
}
