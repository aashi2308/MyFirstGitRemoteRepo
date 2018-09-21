using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> action1 = ActionDelegate.GetDetails;
            action1(1);
            Action<int> action2 = delegate (int id)
            {
                Console.WriteLine(id);
            };
            action2(2);
            Action<int> action3 = id => Console.WriteLine(id);
            action3(3);


            Console.ReadKey();
        }
    }

    class ActionDelegate
    {
        static List<Student> StudentDetails = new List<Student>()
        {
            new Student(){ StudentId=1, StudentName="Ashi"},
            new Student(){ StudentId=2, StudentName=" Siddhi"}
        };

        public static void GetDetails(int id)
        {
            
            if (StudentDetails.Select(x => x.StudentId).FirstOrDefault().Equals(id))
            {
                Console.WriteLine("The id of the Student is {0}",id);
            }
        }

       

    }

    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        
    }
}
