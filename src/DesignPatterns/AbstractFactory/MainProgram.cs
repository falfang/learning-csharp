namespace AbstractFactory
{
    /// <summary>
    /// メインプログラムクラス
    /// </summary>
    internal class MainProgram
    {
        /// <summary>
        /// エントリポイント
        /// </summary>
        /// <param name="args">引数</param>
        public static void Main(string[] args)
        {
            new Client().Do();
        }
    }
}
