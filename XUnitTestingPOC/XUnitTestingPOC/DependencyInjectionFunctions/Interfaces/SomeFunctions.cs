using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XUnitTestingPOC.DependencyInjectionFunctions.Interfaces
{
    public interface ISomeFunctions
    {
        int AddFunction(int a, int b);
        List<int> GenerateList();
        bool CompareTwoStrings(string a, string b);
    }
}
