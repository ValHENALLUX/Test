using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Pupil : Person
    {
        public int Grade { get; set; }

        private List<Activity> listActivities;

        private char [] tabEval;

        public char [] TabEval
        {
            get { return tabEval; }
            set { tabEval = value; }
        }

        public List<Activity> ListActivities
        {
            get
            {
                return listActivities;
            }

            set
            {
                listActivities = value;
            }
        }

        public Pupil(string name, int age, int grade) : base (name, age)
        {
            Grade = grade;
            ListActivities = new List<Activity>();
            TabEval = new char[10];
        }

        public Pupil(string name, int age) : this(name, age, 1)
        {}

        public void AddActivity(Activity activity)
        {
            listActivities.Add(activity);
        }

        public override string ToString()
        {
            string ch = base.ToString();
            int cptActivities = ListActivities.Count();
            if (cptActivities == 0)
            {
                ch += "n'a pas encore choisi d'activité";
            }
            else
            {
                ch += " a choisi les activités suivantes :\n";
                foreach (Activity activity in ListActivities)
                {
                    ch += activity + "\n";
                }
            }
            return ch;
        }
    }
}
