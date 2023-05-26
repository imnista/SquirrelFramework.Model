namespace SquirrelFramework.Model
{
    public abstract class Document
    {
        public string Id { get; set; }

        public Geolocation Geolocation { get; set; }
    }
}