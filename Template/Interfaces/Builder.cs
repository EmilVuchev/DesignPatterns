namespace Template_Method.Interfaces
{
    public abstract class Builder
    {
        public void Build()
        {
            Test();
            Lint();
            Assemble();
            Deploy();
        }

        public abstract void Test();

        public abstract void Lint();

        public abstract void Assemble();
        
        public abstract void Deploy();
    }
}
