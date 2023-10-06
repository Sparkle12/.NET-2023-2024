using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    public class Student
    {

        public List<Subject> Subjects{get; set;}

        public Student(List<Subject> sub)
        {
            Subjects = sub;
        }

        public void PrintAll()
        {
            foreach(Subject a in Subjects)
            {
                a.Print();
            }
        }

        public void Print(int i)
        {
            Subjects[i].Print();
        }

    }
}