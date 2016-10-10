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

            p1.AddActivity(a1);
            p1.AddActivity(a4);

            //System.Console.Write(p1);

            Pupil pupilActComp = p1;

            /*Step3
            System.Console.Write(pupilActComp.PrintPupilActivityCompulsory(
                delegate (Activity activity)
                {
                    return activity.Title + "\n";
                }));
            */

            /*Step4.2
            System.Console.WriteLine(pupilActComp.PrintPupilActivityCompulsory(StaticPrintActivity));
            */

            /*Step5
            PrintActivityDelegate p = new PrintActivityDelegate();

            System.Console.WriteLine(pupilActComp.PrintPupilActivityCompulsory(p.PrintActivity));
            */

            /*Step6
            System.Console.WriteLine(pupilActComp.PrintPupilActivityCompulsory(activity => activity.Title + Environment.NewLine));
            */

            System.Console.Read();
        }
        /*Step4.1
        private static string StaticPrintActivity(Activity activity)
        {
            return activity.Title + "\n";
        }
        */
    }
}
