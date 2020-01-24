using System;
using src;
namespace HeatherTaylor.CodeLou.ExerciseProject
{
    class Program
    {        
        static void Main(string[] args)
        {   
            bool stillRunning = true;
            while (stillRunning) 
            {
                stillRunning = InputStudent();
            }
            static bool InputStudent()
            {
                Console.WriteLine("Enter Student Id");
                var studentId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter First Name");
                var studentFirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                var studentLastName = Console.ReadLine();
                Console.WriteLine("Enter Class Name");
                var className = Console.ReadLine();
                Console.WriteLine("Enter Last Class Completed");
                var lastClass = Console.ReadLine();
                Console.WriteLine("Enter Last Class Completed Date in format MM/dd/YYYY");
                var lastCompletedOn = DateTimeOffset.Parse(Console.ReadLine());
                Console.WriteLine("Enter Start Date in format MM/dd/YYYY");
                var startDate = DateTimeOffset.Parse(Console.ReadLine());

                var studentRecord = new Student();
                studentRecord.StudentId = studentId;
                studentRecord.FirstName = studentFirstName;
                studentRecord.LastName = studentLastName;
                studentRecord.ClassName = className;
                studentRecord.StartDate = startDate;
                studentRecord.LastClassCompleted = lastClass;
                studentRecord.LastClassCompletedOn = lastCompletedOn;
                Console.WriteLine($"Student Id | Name |  Class "); ;
                Console.WriteLine($"{studentRecord.StudentId} | {studentRecord.FirstName} {studentRecord.LastName} | {studentRecord.ClassName} "); ;
                Console.ReadKey();

                Console.WriteLine("Another Student? Yes or no?");
                var answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    return true;
                }
                else if (answer.ToLower() == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine ("No input detected. Goodbye!");
                    return false;
                }                    
            }
        }
    }
}
