using Strategy.Interfaces;

namespace Strategy.ConcreteImplementation
{
    public class Sorter
    {
        private readonly ISortStrategy sorter;

        public Sorter(ISortStrategy sorter)
        {
            this.sorter = sorter;
        }

        public List<int> Sort(List<int> unSortedList)
        {
            return this.sorter.Sort(unSortedList);
        }
    }
}
