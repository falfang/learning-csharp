namespace DependencyInjection.Services
{
    /// <summary>
    /// データ操作サービスインタフェース
    /// </summary>
    public interface IDataService
    {
        /// <summary>
        /// 文字列データを返す
        /// </summary>
        /// <returns>文字列データ</returns>
        public string GetStringData();

        /// <summary>
        /// 整数データを返す
        /// </summary>
        /// <returns>整数データ</returns>
        public int GetIntData();

        /// <summary>
        /// 文字列データを設定する
        /// </summary>
        /// <param name="data">文字列データ</param>
        public void SetStringData(string data);

        /// <summary>
        /// 整数データを設定する
        /// </summary>
        /// <param name="data">整数データ</param>
        public void SetIntData(int data);
    }
}
