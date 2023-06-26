using Strategy.Interfaces;

namespace Strategy.ConcreteImplementation
{
    public class QuickSortStrategy : ISortStrategy
    {
        public List<int> Sort(List<int> dataset)
        {
            Console.WriteLine("Sorting using Quick Sort !");
            return dataset;
        }
    }
}
