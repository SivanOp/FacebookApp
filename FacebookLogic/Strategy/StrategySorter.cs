using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic.Strategy
{
    public class StrategySorter
    {
        private ISortAlgorithm m_SortAlgorithm;

        public ISortAlgorithm SortAlgorithm
        {
            get { return m_SortAlgorithm; }
            set { m_SortAlgorithm = value; }
        }

        public StrategySorter(ISortAlgorithm i_SortAlgorithm)
        {
            m_SortAlgorithm = i_SortAlgorithm;
        }

        public void StrategySort(object[] i_Array)
        {
            for (int index1 = i_Array.Length / 2; index1 > 0; index1 /= 2)
            {
                for (int index2 = index1; index2 < i_Array.Length; index2++)
                {
                    for (int index3 = index2 - index1; index3 >= 0; index3 -= index1)
                    {
                        if (m_SortAlgorithm.Sort(i_Array[index3], i_Array[index3 + index1]))
                        {
                            object temp = i_Array[index3];
                            i_Array[index3] = i_Array[index3 + index1];
                            i_Array[index3 + index1] = temp;
                        }
                    }
                }
            }
        }
    }
}
