namespace DependencyInjection.Services
{
    /// <summary>
    /// インタフェースの実装クラス
    /// </summary>
    public class DataService : IDataService
    {
        /// <summary>
        /// データベースから整数データを取得する
        /// </summary>
        /// <returns>整数データ</returns>
        int IDataService.GetIntData()
        {
            var random = new Random();
            return random.Next(-100, 100);
        }

        /// <summary>
        /// データベースから文字列データを取得する
        /// </summary>
        /// <returns>文字列データ</returns>
        string IDataService.GetStringData()
        {
            // 実際のデータベースに対する処理
            return "Real Data from Database or API";
        }

        /// <summary>
        /// 整数データを設定する
        /// </summary>
        /// <param name="data">整数データ</param>
        void IDataService.SetIntData(int data)
        {
            // 実際のデータベースに対する処理
            var database_int = data;
        }

        /// <summary>
        /// 文字列データを設定する
        /// </summary>
        /// <param name="data">文字列データ</param>
        void IDataService.SetStringData(string data)
        {
            // 実際のデータベースに対する処理
            var database_int = data;
        }
    }
}
