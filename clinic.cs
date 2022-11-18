using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Na_29._10
{
    public abstract class Clinic
    {
        public string Name { get; set; }
        public Clinic(string name)
        {
            Name = name;
        }
    }
}
