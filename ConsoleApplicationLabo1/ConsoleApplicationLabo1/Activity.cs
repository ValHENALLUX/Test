using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Activity
    {
        public string Title { get; set; }

        public bool Compulsory { get; set; }

        public Activity(string title, bool compulsory)
        {
            Title = (title == null)? "tronc commun" : title ;
            Compulsory = compulsory;
        }

        public override string ToString()
        {
            return Title + ( (Compulsory)?" ( obligatoire )":"" );
        }
    }
}
