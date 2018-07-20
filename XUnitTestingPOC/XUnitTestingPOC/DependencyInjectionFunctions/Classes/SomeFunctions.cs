using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XUnitTestingPOC.DependencyInjectionFunctions.Interfaces;

namespace XUnitTestingPOC.DependencyInjectionFunctions.Classes
{
    public class SomeFunctions : ISomeFunctions
    {
        public int AddFunction(int a, int b)
        {
            return a + b;
        }

        public bool CompareTwoStrings(string a, string b)
        {
            return a.Equals(b);
        }

        public List<int> GenerateList()
        {
            return new List<int>(){10,20,30};
        }
    }
}
