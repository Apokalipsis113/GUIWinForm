using System.Collections;

namespace Logic
{
    /// <summary>
    /// <seealso cref="Proxy"/>
    /// </summary>
    public class OfflineProxy : IProxy
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public OfflineProxy()
        {
            data = new ArrayList();
            avegangeData = 0;
            DataUpdated += SetAverangeData;
        }

        private ArrayList data;
        private double avegangeData;

        private event DataUpdatedDelegate DataUpdated;

        public int GetCount()
        {
            return data.Count;
        }
        public void Add(double value)
        {
            data.Add(value);
            DataUpdated();
        }
        public double GetData(int index)
        {
            return (double)data[index];
        }
        public void SetData(int index, double value)
        {
            data[index] = value;
            DataUpdated();
        }
        public void RemoveAt(int index)
        {
            data.RemoveAt(index);
            DataUpdated();
        }
        public double GetAverangeData()
        {
            return avegangeData;
        }
        private void SetAverangeData()
        {
            double summ = 0;
            for (int i = 0; i < data.Count; i++)
                summ += (double)data[i];
            avegangeData = summ / data.Count;
        }
        public void Clear()
        {
            data.Clear();
            avegangeData = 0;
        }
        public ArrayList GetAllData()
        {
            return data;
        }

    }
}
