namespace AbstractFactory.Product
{
    /// <summary>
    /// 製品A1
    /// </summary>
    public class ConcreteProductA1 : IAbstractProductA
    {
        /// <summary>
        /// 製品A1のメソッド
        /// </summary>
        /// <returns>実行メッセージ</returns>
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
