namespace Observer.Subject
{
    /// <summary>
    /// Something has observable logic
    /// </summary>
    public class Subject : ISubject
    {
        /// <summary>
        /// List of observers
        /// </summary>
        private List<Observer.IObserver> _observers = new List<Observer.IObserver>();

        /// <summary>
        /// Constructor
        /// </summary>
        public Subject()
        {
        }

        /// <summary>
        /// The state of subject
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// The subscription management method
        /// </summary>
        /// <param name="observer">what to attach</param>
        public void Attach(Observer.IObserver observer)
        {
            this._observers.Add(observer);
            Console.WriteLine("Subject: Attached an observer");
        }

        /// <summary>
        /// The subscription management method
        /// </summary>
        /// <param name="observer">where from detech</param>
        public void Detach(Observer.IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detach an observer");
        }

        /// <summary>
        /// Trigger an update in each subscriber
        /// </summary>
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers");

            foreach (var observer in this._observers)
            {
                observer.Update(this);
            }
        }

        /// <summary>
        /// Some logic in subject
        /// </summary>
        public void SomeBusinessLogic()
        {
            Console.WriteLine("Subject: I am doing something important");
            this.State = new Random().Next(10);

            // Do heavy logic
            Thread.Sleep(10);

            Console.WriteLine("Subject: My state has just changed to:" + this.State);
            this.Notify();
        }
    }
}
