using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic.Iterator
{
    public interface IAggregateT<T>
    {
        IIteratorT<T> CreateIterator();
    }
}
