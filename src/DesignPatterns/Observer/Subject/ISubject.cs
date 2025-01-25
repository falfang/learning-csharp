namespace Observer.Subject
{
    /// <summary>
    /// Interface for subject
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Attach an observer to the subject
        /// </summary>
        /// <param name="observer">Observer to attach</param>
        public void Attach(Observer.IObserver observer);

        /// <summary>
        /// Detach an observer from the subject
        /// </summary>
        /// <param name="observer">Observer to detach</param>
        public void Detach(Observer.IObserver observer);

        /// <summary>
        /// Notify all observers about an event
        /// </summary>
        public void Notify();
    }
}
