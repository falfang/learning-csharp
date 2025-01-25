namespace AbstractFactory.Product
{
    /// <summary>
    /// 製品B2
    /// </summary>
    public class ConcreteProductB2 : IAbstractProductB
    {
        /// <summary>
        /// 製品B2のメソッド
        /// </summary>
        /// <returns>実行メッセージ</returns>
        public string UsefulFunctionB()
        {
            return "The result of the product B2";
        }

        /// <summary>
        /// 製品B2の追加メソッド
        /// </summary>
        /// <param name="collaborator">協力者</param>
        /// <returns>実行メッセージ</returns>
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B2 collaborating with the ({result})";
        }
    }
}
