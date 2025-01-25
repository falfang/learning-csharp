namespace FactoryMethod.Product
{
    /// <summary>
    /// アカウント情報クラス（Product具象クラス）
    /// </summary>
    public class Account : AbstractProduct
    {
        /// <summary>
        /// フィールド
        /// </summary>
        private readonly string? _owner;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="owner">オーナー名</param>
        public Account(string owner)
        {
            this._owner = owner;
            Console.WriteLine("Create account: " + this._owner);
        }

        /// <summary>
        /// ログ出力
        /// </summary>
        public override void Use()
        {
            Console.WriteLine("Use account: " + this._owner);
        }

        /// <summary>
        /// アカウント情報取得
        /// </summary>
        /// <returns>オーナー名</returns>
        public string? GetOwner()
        {
            return this._owner;
        }
    }
}
