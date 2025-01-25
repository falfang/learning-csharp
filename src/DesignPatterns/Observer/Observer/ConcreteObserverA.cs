using Observer.Subject;

namespace Observer.Observer
{
    /// <summary>
    /// Observer A
    /// </summary>
    public class ConcreteObserverA : IObserver
    {
        /// <summary>
        /// Update observer
        /// </summary>
        /// <param name="subject">What to observe</param>
        public void Update(ISubject subject)
        {
            if (((Subject.Subject)subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event");
            }
        }
    }
}
