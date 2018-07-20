using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XUnitTestingPOC.DependencyInjectionFunctions.Interfaces;

namespace XUnitTestingPOC.DependencyInjectionFunctions
{
    
    public class MainFunctionClass
    {
        //Dependency injection
        private readonly ISomeFunctions _someFunctions;
        public MainFunctionClass(ISomeFunctions someFunctions)
        {
            _someFunctions = someFunctions;
        }

        /// <summary>
        /// Checks if addition of both numbers is greater than 5
        /// for all non zero integers else returns false
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool GreaterThan5(int a, int b)
        {
            if (a == 0 || b == 0)
                return false;
            return 5 <_someFunctions.AddFunction(a, b);
        }

        /// <summary>
        /// Check if two strings are equal or not by returning Yes or No
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string CompareReturnYesOrNo(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
                return null;
            return _someFunctions.CompareTwoStrings(a, b)? "Yes" : "No";
        }

        /// <summary>
        /// Adds additional element to list
        /// </summary>
        /// <returns></returns>
        public List<int> AddElementsToList()
        {
            var list = _someFunctions.GenerateList();
            if (list == null)
            {
                return new List<int>();
            }
            list.AddRange(Enumerable.Range(1,5));
            return list;
        }

    }
}
