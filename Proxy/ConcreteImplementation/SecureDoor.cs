using Proxy.Interfaces;

namespace Proxy.ConcreteImplementation
{
    public class SecureDoor : IDoor
    {
        private readonly IDoor door;

        public SecureDoor(IDoor door)
        {
            this.door = door;
        }

        public void Close()
        {
            this.door.Close();
        }

        public void Open(string password)
        {
            if (Authenticate(password))
            {
                this.door.Open();
            }
            else
            {
                Console.WriteLine("Big no! It ain't possible.");
            }
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        private bool Authenticate(string password)
        {
            return password == "$ecr@t";
        }
    }
}
