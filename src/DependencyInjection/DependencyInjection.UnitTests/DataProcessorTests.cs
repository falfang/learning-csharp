using DependencyInjection.Services;

namespace DependencyInjection.UnitTests
{
    /// <summary>
    /// �f�[�^�e�X�g�̒P�̃e�X�g
    /// </summary>
    public class DataProcessorTests
    {
        /// <summary>
        /// Mock�̒l���Ԃ��Ă��邩�ǂ���
        /// </summary>
        [Fact(DisplayName = "���b�N�̒l���Ԃ��Ă��邩")]
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
