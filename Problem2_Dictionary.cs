using System;
using System.Collections.Generic;

public class Student
{
    public string StudentNumber { get; set; }
    public string Name { get; set; }
    public string Program { get; set; }
    public int YearLevel { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();

        while (true)
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("           STUDENT LOOKUP USING DICTIONARY        ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter Student Number: ");
                string studentNum = Console.ReadLine();

                if (studentDictionary.ContainsKey(studentNum))
                {
                    Console.WriteLine("Student Number already exists!\n");
                    continue;
                }

                Student newStudent = new Student();
                newStudent.StudentNumber = studentNum;

                Console.Write("Enter Name: ");
                newStudent.Name = Console.ReadLine();

                Console.Write("Enter Program: ");
                newStudent.Program = Console.ReadLine();

                Console.Write("Enter Year Level: ");
                newStudent.YearLevel = Convert.ToInt32(Console.ReadLine());

                studentDictionary.Add(studentNum, newStudent);
                Console.WriteLine("\nStudent added successfully!\n");
            }
            else if (choice == "2")
            {
                Console.Write("Enter Student Number to search: ");
                string searchNum = Console.ReadLine();

                if (!studentDictionary.ContainsKey(searchNum))
                {
                    Console.WriteLine("Student Number does not exist[cite: 1].\n");
                }
                else
                {
                    Student foundStudent = studentDictionary[searchNum];
                    
                    Console.WriteLine("\nStudent Found!");
                    Console.WriteLine($"Student Number: {foundStudent.StudentNumber}");
                    Console.WriteLine($"Name: {foundStudent.Name}");
                    Console.WriteLine($"Program: {foundStudent.Program}");
                    Console.WriteLine($"Year Level: {foundStudent.YearLevel}\n");
                }
            }
            else if (choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.\n");
            }
        }
    }
}
