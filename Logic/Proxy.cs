using System;
using System.Collections;

namespace Logic
{
    //Simple delegate for methods that can calculate data
    public delegate void DataUpdatedDelegate();

    /// <summary>
    /// Base class for communication and storage data.
    /// </summary>
    //MarshalByRefObject requested that class is Serializable
    [Serializable]
    public class Proxy : MarshalByRefObject, IProxy
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Proxy()
        {
            data = new ArrayList();
            _lock = new object();
            avegangeData = 0;
            DataUpdated += SetAverangeData;     //method that cab execute algorithm 
        }
        /// <summary>
        /// Mutex for synchronization of shared object. Used only for write.
        /// </summary>
        private object _lock;
        /// <summary>
        /// Main collection, used ArrayList collection for make class Serializable.
        /// </summary>
        private ArrayList data;
        private double avegangeData;
        /// <summary>
        /// Event called every time when data has beed changed
        /// </summary>
        public event DataUpdatedDelegate DataUpdated;

        public int GetCount()
        {
            return data.Count;
        }
        public void Add(double value)
        {
            lock (_lock)
            {
                data.Add(value);
                DataUpdated();
            }
        }
       
        public double GetData(int index)
        {
            return (double)data[index];
        }
        public void SetData(int index, double value)
        {
            lock (_lock)
            {
                data[index] = value;
                DataUpdated();
            }
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
            lock (_lock)
            {
                avegangeData = summ / data.Count;
            }
        }
               
        public void Clear()
        {
            lock (_lock)
            {
                data.Clear();
                avegangeData = 0;
            }
        }

        public ArrayList GetAllData()
        {
            return data;
        }

    }
}
