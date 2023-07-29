using Template_Method.Interfaces;

namespace Template_Method.ConcreteImplementation
{
    public class AndroidBuilder : Builder
    {
        public override void Assemble()
        {
            Console.WriteLine("Assembling the android build");
        }

        public override void Deploy()
        {
            Console.WriteLine("Deploying android build to server");
        }

        public override void Lint()
        {
            Console.WriteLine("Linting the android code");
        }

        public override void Test()
        {
            Console.WriteLine("Running android tests");
        }
    }
}
