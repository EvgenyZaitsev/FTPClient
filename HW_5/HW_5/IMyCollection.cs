using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public interface IMyCollection
    {
        void FillList(int amount);
        void ReadList();
        void FindInList();
        void RemoveFromList();
    }
}
