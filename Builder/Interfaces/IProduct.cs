namespace Builder.Interfaces
{
    public interface IProduct
    {
        string Name { get; }

        bool IsAvailable { get; set; }
    }
}
