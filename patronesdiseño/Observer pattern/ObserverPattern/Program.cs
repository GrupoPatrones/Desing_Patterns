using System;
using ObserverPattern.Techniques.UsingNet.Observers;
using ObserverPattern.Techniques.UsingNet.Providers;

namespace ObserverPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LaunchTechnique(Technique.UsingEventAndDelegate);
        }

        private static void LaunchTechnique(Technique technique)
        {
            switch (technique)
            {
                case Technique.UsingNet:
                    TechniqueUsingNet();
                    break;
                case Technique.UsingEventAndDelegate:
                    TechniqueEventAndDelegate();
                    break;
                case Technique.UsingPoo:
                    TechniquePoo();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(technique), technique, null);
            }
        }

        /// <summary>
        ///     Esta tecnica, hace uso de las interfaces proveidas por el framework
        ///     <see cref="IObservable{T}" /> <see cref="IObserver{T}" />
        /// </summary>
        private static void TechniqueUsingNet()
        {
            var provider = new WeatherDataProvider(); //creamos el proveedor
            var currentDisp = new CurrentConditionsDisplay(provider); //Suscribimos a [Condiciones actuales] al proveedor
            var forecastDisp = new ForecastDisplay(provider); //Suscribimos a [Prediciones del clima] al proveedor
            provider.SetMeasurements(40, 78, 3); //Indicamos al proveedor unas condiciones de clima 
            Console.WriteLine();
            provider.SetMeasurements(45, 79, 4); //..
            Console.WriteLine();
            provider.SetMeasurements(46, 73, 6); //..
            //Remove forecast display
            forecastDisp.Unsubscribe(); // Desinscribimos a [Prediciones del clima] debido a que éste ya no desea ser notificado
            Console.WriteLine();
            provider.SetMeasurements(36, 53, 8);//Comprobamos que al indicar unas nuevas condiciones de clima, el observador [Prediciones del clima] ya no es notificado
            Console.Read();
        }
        /// <summary>
        /// Esta tecnica hace uso de eventos y delegados (muy usada)
        /// <see cref="EventHandler{TEventArgs}"/>
        /// </summary>
        private static void TechniqueEventAndDelegate()
        {
            var provider = new Techniques.UsingEventsAndDelegates.Providers.WeatherDataProvider(); //creamos el proveedor
            var currentDisp = new Techniques.UsingEventsAndDelegates.Observers.CurrentConditionsDisplay(provider); //Suscribimos a [Condiciones actuales] al proveedor
            var forecastDisp = new Techniques.UsingEventsAndDelegates.Observers.ForecastDisplay(provider); //Suscribimos a [Prediciones del clima] al proveedor
            provider.SetMeasurements(40, 78, 3); //Indicamos al proveedor unas condiciones de clima 
            Console.WriteLine();
            provider.SetMeasurements(45, 79, 4); //..
            Console.WriteLine();
            provider.SetMeasurements(46, 73, 6); //..
            //Remove forecast display
            forecastDisp.Unsubscribe(); // Desinscribimos a [Prediciones del clima] debido a que éste ya no desea ser notificado
            Console.WriteLine();
            provider.SetMeasurements(36, 53, 8);//Comprobamos que al indicar unas nuevas condiciones de clima, el observador [Prediciones del clima] ya no es notificado
            Console.Read();
        }
        /// <summary>
        /// Esta tecnica hace uso del patro en su forma mas pura, en donde los contratos
        /// de la clase observada y los observadores son creados y no proveidos (como el caso del framework)
        /// </summary>
        private static void TechniquePoo()
        {
            var provider = new Techniques.UsingPoo.Providers.WeatherDataProvider();  //creamos el proveedor
            var currentDisp = new Techniques.UsingPoo.Observers.CurrentConditionsDisplay(provider); //Suscribimos a [Condiciones actuales] al proveedor
            var forecastDisp = new Techniques.UsingPoo.Observers.ForecastDisplay(provider); //Suscribimos a [Prediciones del clima] al proveedor

            provider.SetMeasurements(40, 78, 3); //Indicamos al proveedor unas condiciones de clima 
            Console.WriteLine();
            provider.SetMeasurements(45, 79, 4); //..
            Console.WriteLine();
            provider.SetMeasurements(46, 73, 6); //..
            //Remove forecast display
            forecastDisp.Dispose(); // Desinscribimos a [Prediciones del clima] debido a que éste ya no desea ser notificado
            Console.WriteLine();
            provider.SetMeasurements(36, 53, 8);//Comprobamos que al indicar unas nuevas condiciones de clima, el observador [Prediciones del clima] ya no es notificado
            Console.Read();
        }
    }

    public enum Technique
    {
        UsingNet,
        UsingEventAndDelegate,
        UsingPoo
    }
}