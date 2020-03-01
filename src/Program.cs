using System;
using src;
using System.Linq;
using System.Collections.Generic;
namespace src
{
    class Program
    {

        private static void DisplayMap()
        {
            Console.Clear();
            Console.WriteLine("Select from the following operations:");
            Console.WriteLine("1: Enter new student");
            Console.WriteLine("2: List all students");
            Console.WriteLine("3: Search for student by name");
            Console.WriteLine("4: Exit");
        }
        
                

        class DisplayStudent
        {
            string studentInfo = "Student ID " + "Name " + "Class ";
        }
        static List<Student> studentList = new List<Student>();
        static void Main(string[] args)
        {
            bool stillRunning = true;


            while (stillRunning)
            {
                DisplayMap();
                int Answer;
                int.TryParse(Console.ReadLine(), out Answer);
                
                switch (Answer)
                {
                    case 1:

                        InputStudent();
                        break;

                    case 2:

                        ListStudents();
                        break;

                    case 3:

                        FindStudent();
                        break;


                    case 4:

                        stillRunning = false;
                        break;
                }

            }
        }

        static void ListStudents()
        {
            Console.WriteLine($"Student Id | Name |  Class ");
            foreach(Student i in studentList)
            {
                Console.WriteLine($"{i.StudentId} | {i.FirstName} {i.LastName} | {i.ClassName} ");
            }
            Console.ReadKey();
        }

        private static void FindStudent()
        {
            Console.WriteLine("Who are you looking for?");
            string LookStudent = Console.ReadLine();
            bool StudentFound = true;
            foreach (Student i in studentList)
            {
                var FindName = $"{i.FirstName} {i.LastName}";
                if(LookStudent == FindName)
                {
                    StudentFound = true;
                    Console.WriteLine($"{i.StudentId} | {i.FirstName} {i.LastName} | {i.ClassName} ");
                    break;
                }
                else
                {
                    StudentFound = false;
                    
                }
            }
            if (StudentFound == false)
            {
                Console.WriteLine("Student not found.");
            }
            Console.ReadKey();
            DisplayMap();

        }
        static void InputStudent()
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

            var studentRecord = new src.Student();
            studentRecord.StudentId = studentId;
            studentRecord.FirstName = studentFirstName;
            studentRecord.LastName = studentLastName;
            studentRecord.ClassName = className;
            studentRecord.StartDate = startDate;
            studentRecord.LastClassCompleted = lastClass;
            studentRecord.LastClassCompletedOn = lastCompletedOn;
            Console.WriteLine($"Student Id | Name |  Class ");
            Console.WriteLine($"{studentRecord.StudentId} | {studentRecord.FirstName} {studentRecord.LastName} | {studentRecord.ClassName} ");
            Console.ReadKey();
            studentList.Add(studentRecord);
            Console.WriteLine("Another Student? Yes or no?");
            var answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
                DisplayMap();
            }
            else if (answer.ToLower() == "no")
            {
                DisplayMap();
            }
            else
            {
                Console.WriteLine("No input detected. Goodbye!");
            }
        }
    }
}
