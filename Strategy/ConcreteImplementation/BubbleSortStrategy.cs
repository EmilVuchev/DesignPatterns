using Strategy.Interfaces;

namespace Strategy.ConcreteImplementation
{
    public class BubbleSortStrategy : ISortStrategy
    {
        public List<int> Sort(List<int> dataset)
        {
            Console.WriteLine("Sorting using Bubble Sort !");
            return dataset;
        }
    }
}
