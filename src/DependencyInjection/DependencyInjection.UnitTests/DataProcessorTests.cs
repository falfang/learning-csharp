using DependencyInjection.Services;

namespace DependencyInjection.UnitTests
{
    /// <summary>
    /// データテストの単体テスト
    /// </summary>
    public class DataProcessorTests
    {
        /// <summary>
        /// Mockの値が返ってくるかどうか
        /// </summary>
        [Fact(DisplayName = "モックの値が返ってくるか")]
        public void ProcessData_ShouldReturnProcessedMockData()
        {
            // Arrange
            var mockDataService = new MockDataService();
            var processor = new DataProcessor(mockDataService);

            // Act
            var int_result = processor.ProcessIntData(0);
            var string_result = processor.ProcessStringData("abc");

            // Assert
            Assert.Equal(-1, int_result);
            Assert.Equal("Mock data", string_result);
        }
    }
}
