namespace AbstractFactory.Product
{
    /// <summary>
    /// 製品インタフェース
    /// </summary>
    public interface IAbstractProduct
    {
    }

    /// <summary>
    /// 製品Aインタフェース
    /// </summary>
    public interface IAbstractProductA : IAbstractProduct
    {
        /// <summary>
        /// 製品Aメソッド
        /// </summary>
        /// <returns>実行メッセージ</returns>
        string UsefulFunctionA();
    }

    /// <summary>
    /// 製品Bインタフェース
    /// </summary>
    public interface IAbstractProductB : IAbstractProduct
    {
        /// <summary>
        /// 製品Bメソッド
        /// </summary>
        /// <returns>実行メッセージ</returns>
        string UsefulFunctionB();

        /// <summary>
        /// 製品B追加メソッド
        /// </summary>
        /// <param name="collaborator">協力者</param>
        /// <returns>実行メッセージ</returns>
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
