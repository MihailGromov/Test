using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxer_Week2
{
    public class Boxer
    {
        //public properties
        public string Name { get; set; }
        public int Strenght { get; set; }

        public override string ToString()
        {
            return String.Format("Name: {0}:{1}",Name,Strenght);
        }
    } //end class
}
