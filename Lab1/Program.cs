// See https://aka.ms/new-console-template for more information
using Laborator1;

Random rnd = new();
List<Student> students = new();
List<Subject> PossibleSubjects = new List<Subject>(){
                                                     new Subject("Math","1h"),
                                                     new Subject("English","30min"),
                                                     new Subject("Programing","2h")
                                                    };

Console.WriteLine("How many Students?");
int n = Convert.ToInt32(Console.ReadLine());

for(int i = 0;i<n;i++)
{
  int x = rnd.Next(PossibleSubjects.Count()), y = rnd.Next(x,PossibleSubjects.Count());
  students.Add(new Student(PossibleSubjects.GetRange(x,y - x +1)));  
} 
int nr = 1;
foreach(Student a in students)
{
    Console.WriteLine("Student nr "+ nr);
    a.PrintAll();
    nr++;
}