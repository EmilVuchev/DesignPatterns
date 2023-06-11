using System.Collections;

namespace Iterator.ConcreteImplementation
{
    public class StationList : IEnumerable<RadioStation>
    {
        private readonly List<RadioStation> stations;

        public StationList()
        {
            this.stations = new List<RadioStation>();
        }

        public RadioStation this[int index]
        {
            get { return this.stations[index]; }
            set { this.stations[index] = value; }
        }

        public void Add(RadioStation station)
        {
            stations.Add(station);
        }

        public void Remove(RadioStation station)
        {
            stations.Remove(station);
        }
        public IEnumerator<RadioStation> GetEnumerator()
        {
            return this.stations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.stations.GetEnumerator();
        }
    }
}
