using System.Threading.Tasks.Dataflow;

namespace ProducerComsumer
{
    /// <summary>
    /// Main Program class
    /// </summary>
    public class MainProgram
    {
        /// <summary>
        /// Create new source
        /// </summary>
        /// <param name="target">Created source</param>
        public static void Produce(ITargetBlock<byte[]> target)
        {
            var rand = new Random();

            for (int i = 0; i < 100; ++i)
            {
                var buffer = new byte[1024];
                rand.NextBytes(buffer);

                target.Post(buffer);
            }

            target.Complete();
        }

        /// <summary>
        /// Calculate gross byte numbers of received data asynchronously (Using only one consumer)
        /// </summary>
        /// <param name="source">Source for consumption</param>
        /// <returns>Result of consumption</returns>
        public static async Task<int> ConsumeAsyncWithSingleConsumer(ISourceBlock<byte[]> source)
        {
            int bytesProcessed = 0;

            while (await source.OutputAvailableAsync())
            {
                byte[] data = await source.ReceiveAsync();
                bytesProcessed += data.Length;
            }

            return bytesProcessed;
        }

        /// <summary>
        /// Calculate gross byte numbers of received data asynchronously (Using multiple consumer)
        /// </summary>
        /// <param name="source">Source for consumption</param>
        /// <returns>Result of comsumption</returns>
        public static async Task<int> ConsumeAsyncWithMultiConsumer(IReceivableSourceBlock<byte[]> source)
        {
            int bytesProcessed = 0;
            while (await source.OutputAvailableAsync())
            {
                while (source.TryReceive(out var data))
                {
                    bytesProcessed += data.Length;
                }
            }

            return bytesProcessed;
        }

        /// <summary>
        /// Main Process
        /// </summary>
        /// <param name="args">Arguments</param>
        /// <returns>Process task</returns>
        public static async Task Main(string[] args)
        {
            var buffer = new BufferBlock<byte[]>();

            var consumerTask = ConsumeAsyncWithMultiConsumer(buffer);
            Produce(buffer);

            var bytesProcessed = await consumerTask;

            Console.WriteLine($"Processed {bytesProcessed:#,#} bytes");

            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
