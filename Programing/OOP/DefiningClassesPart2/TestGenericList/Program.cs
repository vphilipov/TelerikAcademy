using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GenericList;

namespace TestGenericList
{
    class Program
    {
        static void Main()
        {
            GenericList<int> someList = new GenericList<int>(10);
            someList.Add(7);
            Console.WriteLine(someList[0]);
            someList.Add(3846);
            Console.WriteLine("Element 3846 is at position {0}", someList.FindElement(3846));

            Console.WriteLine("Min: {0}", someList.Min());

            Console.WriteLine("Max: {0}", someList.Max());

            Console.WriteLine(someList);

            someList.Remove(0);
            Console.WriteLine(someList[0]);
        }
    }
}
