namespace Prototype.ConcreteImplementation
{
    public class Sheep
    {
        public Sheep(string name, string category)
        {
            Name = name;
            Category = category;
        }

        public string Name { get; set; }

        public string Category { get; set; }

        public Sheep Clone()
        {
            return MemberwiseClone() as Sheep;
        }
    }
}
