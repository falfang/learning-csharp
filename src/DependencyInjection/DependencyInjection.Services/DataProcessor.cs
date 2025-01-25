namespace DependencyInjection.Services
{
    /// <summary>
    /// データ操作クラス
    /// </summary>
    public class DataProcessor
    {
        /// <summary>
        /// データ操作サービス
        /// </summary>
        private readonly IDataService _dataService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="dataService">データ操作サービス</param>
        public DataProcessor(IDataService dataService)
        {
            this._dataService = dataService;
        }

        /// <summary>
        /// 文字列データを操作する
        /// </summary>
        /// <param name="data">書き込む文字列データ</param>
        /// <returns>操作後の文字列データ</returns>
        public string ProcessStringData(string data)
        {
            this._dataService.SetStringData(data);
            return this._dataService.GetStringData();
        }

        /// <summary>
        /// 整数データを操作する
        /// </summary>
        /// <param name="data">書き込む整数データ</param>
        /// <returns>操作後の整数データ</returns>
        public int ProcessIntData(int data)
        {
            this._dataService.SetIntData(data);
            return this._dataService.GetIntData();
        }
    }
}
