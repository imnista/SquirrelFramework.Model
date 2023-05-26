namespace SquirrelFramework.Model
{
    public class Geolocation
    {
        public Geolocation()
        {
        }

        public Geolocation(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public Geolocation(double longitude, double latitude, double altitude)
        {
            Longitude = longitude;
            Latitude = latitude;
            Altitude = altitude;
        }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public double Altitude { get; set; }

        public string ToDisplayString()
        {
            return $"{Longitude}, {Latitude}";
        }
    }
}