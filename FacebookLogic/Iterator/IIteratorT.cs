using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookLogic.Iterator
{
    public interface IIteratorT<T>
    {
        void Reset();

        bool MoveNext();

        bool IsDone { get; }

        T Current { get; }

        IEnumerable<T> NextItem { get; }
    }
}
