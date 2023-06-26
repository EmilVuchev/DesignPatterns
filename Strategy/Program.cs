using Strategy.ConcreteImplementation;

var unSortedList = new List<int> { 1, 10, 2, 16, 19 };

var sorter = new Sorter(new BubbleSortStrategy());
sorter.Sort(unSortedList);

sorter = new Sorter(new QuickSortStrategy());
sorter.Sort(unSortedList);
