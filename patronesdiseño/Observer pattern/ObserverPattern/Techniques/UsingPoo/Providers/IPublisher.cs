using ObserverPattern.Techniques.UsingPoo.Observers;

namespace ObserverPattern.Techniques.UsingPoo.Providers
{
    public interface IPublisher
    {
        /// <summary>
        /// Metodo para registrar/inscribir un observador
        /// </summary>
        /// <param name="subscriber"></param>
        void RegisterSubscriber(ISubscriber subscriber);
        /// <summary>
        /// Metodo para desinscribir un observaodr
        /// </summary>
        /// <param name="subscriber"></param>
        void RemoveSubscriber(ISubscriber subscriber);
    }
}