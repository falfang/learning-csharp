namespace AbstractFactory.Product
{
    /// <summary>
    /// 製品A2
    /// </summary>
    public class ConcreteProductA2 : IAbstractProductA
    {
        /// <summary>
        /// 製品A2のメソッド
        /// </summary>
        /// <returns>実行メッセージ</returns>
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}
