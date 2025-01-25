using FactoryMethod.Product;

namespace FactoryMethod.Factory
{
    /// <summary>
    /// アカウント生成クラス
    /// </summary>
    public class AccountFactory : AbstractFactory
    {
        private List<string> _owners;

        /// <summary>
        /// Constructor
        /// </summary>
        public AccountFactory()
        {
            this._owners = new List<string>();
        }

        /// <summary>
        /// オーナー名一覧を取得する
        /// </summary>
        /// <returns>オーナー名一覧</returns>
        public List<string> GetOwners()
        {
            return this._owners;
        }

        /// <summary>
        /// 製品を生産する
        /// </summary>
        /// <param name="owner">オーナー名</param>
        /// <returns>アカウント</returns>
        protected override AbstractProduct CreateProduct(string owner)
        {
            return new Account(owner);
        }

        /// <summary>
        /// 製品を登録する
        /// </summary>
        /// <param name="product">製品</param>
        protected override void RegisterProduct(AbstractProduct product)
        {
            this._owners.Add(((Account)product).GetOwner());
        }
    }
}
