using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new Pupil("Bidon", 6);

            Activity a1 = new Activity("test1", true);
            Activity a2 = new Activity("test2", false);
            Activity a3 = new Activity("test3", false);
            Activity a4 = new Activity("test4", true);
            Activity a5 = new Activity("test5", false);

            System.Console.Write(p1);

            System.Console.Read();
        }
    }
}
