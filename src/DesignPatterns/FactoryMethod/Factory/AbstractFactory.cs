using FactoryMethod.Product;

namespace FactoryMethod.Factory
{
    /// <summary>
    /// Factory抽象クラス
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// Create関数
        /// </summary>
        /// <param name="owner">オーナー名</param>
        /// <returns>製品</returns>
        public AbstractProduct Create(string owner)
        {
            AbstractProduct product = this.CreateProduct(owner);
            this.RegisterProduct(product);
            return product;
        }

        /// <summary>
        /// 生成クラス
        /// </summary>
        /// <param name="owner">製品を生産する</param>
        /// <returns>製品</returns>
        protected abstract AbstractProduct CreateProduct(string owner);

        /// <summary>
        /// 登録クラス
        /// </summary>
        /// <param name="product">製品</param>
        protected abstract void RegisterProduct(AbstractProduct product);
    }
}
