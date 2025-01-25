using AbstractFactory.Factory;

namespace AbstractFactory
{
    /// <summary>
    /// Factoryを利用するクラス
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Factoryを使用する
        /// </summary>
        public void Do()
        {
            Console.WriteLine("=== Factory1 ===");
            this.ClientMethod(new ConcreteFactory1());

            Console.WriteLine("=== Factory2 ===");
            this.ClientMethod(new ConcreteFactory2());
        }

        /// <summary>
        /// Client用のメソッド
        /// </summary>
        /// <param name="factory">ファクトリ</param>
        private void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
