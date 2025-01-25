using DependencyInjection.Services;

namespace DependencyInjection.UnitTests
{
    /// <summary>
    /// データ操作サービスのモック
    /// </summary>
    public class MockDataService : IDataService
    {
        /// <summary>
        /// モックから整数データを返す
        /// </summary>
        /// <returns>-1</returns>
        int IDataService.GetIntData()
        {
            var random = new Random();
            return -1;
        }

        /// <summary>
        /// モックから文字列データを返す
        /// </summary>
        /// <returns>"Mock data"</returns>
        string IDataService.GetStringData()
        {
            // 実際のデータベースに対する処理
            return "Mock data";
        }

        /// <summary>
        /// モックに整数データを設定する
        /// </summary>
        /// <param name="data">整数データ</param>
        void IDataService.SetIntData(int data)
        {
            // 実際のデータベースに対する処理
            var database_int = data;
        }

        /// <summary>
        /// モックに文字列データを設定する
        /// </summary>
        /// <param name="data">文字列データ</param>
        void IDataService.SetStringData(string data)
        {
            // 実際のデータベースに対する処理
            var database_int = data;
        }
    }
}
