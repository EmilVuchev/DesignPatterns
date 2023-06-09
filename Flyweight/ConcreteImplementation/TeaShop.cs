namespace Flyweight.ConcreteImplementation
{
    public class TeaShop
    {
        private readonly Dictionary<int, KarakTea> orders;
        private readonly TeaMaker maker;

        public TeaShop(TeaMaker maker)
        {
            this.maker = maker;
            this.orders = new Dictionary<int, KarakTea>();
        }

        public void TakeOrder(string teaType, int table)
        {
            orders[table] = maker.Make(teaType);
        }

        public void Serve()
        {
            foreach (var table in orders.Keys)
            {
                Console.WriteLine($"Serving Tea to table # {table}");
            }
        }
    }
}
