using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    public class Subject
    {
        public string Name { get; set; }

        public string Duration { get; set; }


        public Subject(string name, string duration)
        {
            Name = name;
            Duration = duration;
        }

        public void Print()
        {
            Console.WriteLine( Name + " " + Duration);
        }
    }
}