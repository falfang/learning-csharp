namespace AbstractFactory.Product
{
    /// <summary>
    /// 製品B1
    /// </summary>
    public class ConcreteProductB1 : IAbstractProductB
    {
        /// <summary>
        /// 製品B1のメソッド
        /// </summary>
        /// <returns>実行メッセージ</returns>
        public string UsefulFunctionB()
        {
            return "The result of the product B1";
        }

        /// <summary>
        /// 製品B1の追加メソッド
        /// </summary>
        /// <param name="collaborator">協力者</param>
        /// <returns>実行メッセージ</returns>
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }
    }
}
