using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            Student feature = new Student();
            feature.Name = "Ali".ToLower();
            feature.fatherName = "Ahmad".ToLower();
            feature.age = 20;
            feature.average = 19.0;
            feature.isMale = true;

            feature.Name = "Zahra".ToLower();
            feature.fatherName = "hasan".ToLower();
            feature.age = 19;
            feature.average = 20.0;
            feature.isMale = false;
        }
    }
}
