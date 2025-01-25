using Observer.Subject;

namespace Observer.Observer
{
    /// <summary>
    /// Interface for observer
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Receive update from subject
        /// </summary>
        /// <param name="subject">What to observe</param>
        public void Update(ISubject subject);
    }
}
