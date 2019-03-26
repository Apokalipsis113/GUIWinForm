using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IProxy
    {
        void Add(double value);
        void RemoveAt(int index);
        int GetCount();
        double GetData(int index);
        void SetData(int index, double value);
        ArrayList GetAllData();
        double GetAverangeData();
        void Clear();
    }
}
