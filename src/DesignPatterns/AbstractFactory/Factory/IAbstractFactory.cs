using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    /// <summary>
    /// Factoryインタフェース
    /// </summary>
    public interface IAbstractFactory
    {
        /// <summary>
        /// ProductAを作成する
        /// </summary>
        /// <returns>ProductA</returns>
        IAbstractProductA CreateProductA();

        /// <summary>
        /// ProductBを作成する
        /// </summary>
        /// <returns>ProductB</returns>
        IAbstractProductB CreateProductB();
    }
}
