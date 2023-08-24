using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic.Strategy
{
    public interface ISortAlgorithm
    {
        bool Sort(object i_FirstItemToCompare, object i_SecondItemToCompare);
    }
}
