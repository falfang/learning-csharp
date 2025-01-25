using Observer.Observer;

namespace Observer
{
    /// <summary>
    /// メインプログラムクラス
    /// </summary>
    public class MainProgram
    {
        /// <summary>
        /// エントリポイント
        /// </summary>
        /// <param name="args">引数</param>
        public static void Main(string[] args)
        {
            // The client node
            var subject = new Subject.Subject();

            // Create observerA and attach
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            // Create observerB and attach
            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            // Do logic
            subject.SomeBusinessLogic();

            // Detach only observerB from subject
            subject.Detach(observerB);

            // Do logic again
            subject.SomeBusinessLogic();
        }
    }
}
