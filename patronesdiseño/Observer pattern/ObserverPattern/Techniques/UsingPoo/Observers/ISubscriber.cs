using ObserverPattern.Model;

namespace ObserverPattern.Techniques.UsingPoo.Observers
{
    public interface ISubscriber
    {
        /// <summary>
        /// Metodo lanzado por la clase observada para notificar a los observadores,
        /// es aqui donde los observadores se enteran que la clase observada ha terminado su proceso y ha notificado
        /// la accion a los observadores
        /// </summary>
        /// <param name="data"></param>
        void Update(WeatherData data);
    }
}