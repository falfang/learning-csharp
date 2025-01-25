using Observer.Subject;

namespace Observer.Observer
{
    /// <summary>
    /// Observer B
    /// </summary>
    public class ConcreteObserverB : IObserver
    {
        /// <summary>
        /// Update observer
        /// </summary>
        /// <param name="subject">What to observe</param>
        public void Update(ISubject subject)
        {
            if (((Subject.Subject)subject).State == 0 || ((Subject.Subject)subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event");
            }
        }
    }
}
