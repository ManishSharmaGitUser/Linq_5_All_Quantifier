using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_5_All_Quantifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student[] demo_student_data = 
                  {
                   new Student
                      { 
                         Name = "Manish", Marks = 78 ,
                         Subjects = new Subject[]
                         { 
                             new Subject{SubjectName = "Math" ,SubjectMarks=75 },
                             new Subject{SubjectName = "English" ,SubjectMarks=80 },
                             new Subject{SubjectName = "Art" ,SubjectMarks=86 },
                             new Subject{SubjectName = "History" ,SubjectMarks=91 }
                         
                         }
                   },
                   new Student
                      {
                         Name = "Suresh", Marks = 81 ,
                         Subjects = new Subject[]
                         {
                             new Subject{SubjectName = "Math" ,SubjectMarks=68 },
                             new Subject{SubjectName = "English" ,SubjectMarks=50 },
                             new Subject{SubjectName = "Art" ,SubjectMarks=34 },
                             new Subject{SubjectName = "History" ,SubjectMarks=55 }

                         }
                   },

                   new Student
                      {
                         Name = "Alam", Marks = 51 ,
                         Subjects = new Subject[]
                         {
                             new Subject{SubjectName = "Math" ,SubjectMarks=6 },
                             new Subject{SubjectName = "English" ,SubjectMarks=5 },
                             new Subject{SubjectName = "Art" ,SubjectMarks=30 },
                             new Subject{SubjectName = "History" ,SubjectMarks=10 }

                         }
                   },
                   new Student
                      {
                         Name = "Kuamr", Marks = 78 ,
                         Subjects = new Subject[]
                         {
                             new Subject{SubjectName = "Math" ,SubjectMarks=75 },
                             new Subject{SubjectName = "English" ,SubjectMarks=80 },
                             new Subject{SubjectName = "Art" ,SubjectMarks=86 },
                             new Subject{SubjectName = "History" ,SubjectMarks=91 }

                         }
                   },


                 };


            //find student who got above 50 numbers in all subject 
            var result = demo_student_data.Where(x => x.Subjects.All(y => y.SubjectMarks > 50)).Select(x=>x.Name).ToList();


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }


    }

    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public Subject[] Subjects { get; set; }
    }

    public class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectMarks { get; set; }
    }
}
