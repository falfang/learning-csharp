using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    /// <summary>
    /// Factory1クラス
    /// </summary>
    public class ConcreteFactory1 : IAbstractFactory
    {
        /// <summary>
        /// Factory1でProductAを作成する
        /// </summary>
        /// <returns>Factory1で作成したProductA</returns>
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        /// <summary>
        /// Factory1でProductBを作成する
        /// </summary>
        /// <returns>Factory1で作成したProductB</returns>
        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
