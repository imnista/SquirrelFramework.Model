namespace SquirrelFramework.Model
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class CollectionAttribute : Attribute
    {
        public CollectionAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}