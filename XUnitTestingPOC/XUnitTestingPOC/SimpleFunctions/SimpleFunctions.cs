using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace XUnitTestingPOC.SimpleFunctions
{
    public class SimpleFunctions
    {
        /// <summary>
        /// Method returns sum for all number greater than or equal to 0
        /// else returns -1;
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int PositiveIntegerAdditions(int a, int b)
        {
            int sum = 0;

            if (a < 0 || b < 0)
            {
                return -1;
            }
                sum = a + b;
            return sum;
        }

        /// <summary>
        /// Method returns Even or Odd.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public string EvenOrOdd(int a)
        {
            if (a == 0)
                return "Please enter a non zero number";
            if (a % 2 == 0)
                return "Even";
            return "Odd";
        }

        /// <summary>
        /// Method returns true for even and false for odd.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool SimpleBoolFunction(int a)
        {
            if (a % 2 == 0)
                return true;
            return false;
        }

        /// <summary>
        /// Method returns null for false and Empty List for true.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public List<int> SimpleNullFunction(bool a)
        {
            if (a)
                return new List<int>();
            return null;
        }
    }
}
