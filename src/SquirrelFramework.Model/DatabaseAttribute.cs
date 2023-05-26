namespace SquirrelFramework.Model
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class DatabaseAttribute : Attribute
    {
        public DatabaseAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}