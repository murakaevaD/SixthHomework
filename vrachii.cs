using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Na_29._10
{
    public class vrachii
    {
        public void Vrachi(string v)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\дания\source\repos\Na_29.10\врачи.txt");
            foreach (var line in lines) 
                Console.WriteLine(line);
        }
    }
}
