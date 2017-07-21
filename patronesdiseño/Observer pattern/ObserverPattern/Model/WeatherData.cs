namespace ObserverPattern.Model
{
    public class WeatherData
    {
        public WeatherData(float temp, float humid, float pres)
        {
            Temperature = temp;
            Humidity = humid;
            Pressure = pres;
        }

        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
    }
}