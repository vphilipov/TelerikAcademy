using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using CustomVersionAttribute;

namespace TestAttribute
{
    [Version("1.0")]
    class Program
    {
        [Version("2.0")]
        static void Main()
        {
            Type type = typeof(Program);
            object[] versionType = type.GetCustomAttributes(false);
            Console.WriteLine("Class version is {0}.", ((VersionAttribute)versionType[0]).Version);
        }
    }
}
