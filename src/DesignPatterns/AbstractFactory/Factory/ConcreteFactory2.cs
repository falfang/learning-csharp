using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    /// <summary>
    /// Factory2クラス
    /// </summary>
    public class ConcreteFactory2 : IAbstractFactory
    {
        /// <summary>
        /// Factory2でProductAを作成する
        /// </summary>
        /// <returns>Factory2で作成したProductA</returns>
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        /// <summary>
        /// Factory2でProductBを作成する
        /// </summary>
        /// <returns>Factory2で作成したProductB</returns>
        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
