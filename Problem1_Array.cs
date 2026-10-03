using System;

struct Student
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[10];
        int count = 0;

        while (true)
        {
            Console.WriteLine("      STUDENT RECORD MANAGEMENT");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.Write("\nEnter choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "6") break;

            switch (choice)
            {
                case "1":
                    if (count < 10)
                    {
                        Console.Write("Enter Student Number: ");
                        students[count].StudentNumber = Console.ReadLine();
                        Console.Write("Enter Name: ");
                        students[count].Name = Console.ReadLine();
                        Console.Write("Enter Program: ");
                        students[count].Program = Console.ReadLine();
                        Console.Write("Enter Year Level: ");
                        students[count].YearLevel = int.Parse(Console.ReadLine());
                        count++;
                        Console.WriteLine("\nStudent added successfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("Array is full!\n");
                    }
                    break;

                case "2":
                    Console.WriteLine("          STUDENT RECORDS");

                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"Student Number: {students[i].StudentNumber}");
                        Console.WriteLine($"Name: {students[i].Name}");
                        Console.WriteLine($"Program: {students[i].Program}");
                        Console.WriteLine($"Year Level: {students[i].YearLevel}\n");
                    }
                    break;

                case "3":
                    Console.Write("Enter Student Number: ");
                    string searchId = Console.ReadLine();
                    for (int i = 0; i < count; i++)
                    {
                        if (students[i].StudentNumber == searchId)
                        {
                            Console.WriteLine($"\nName: {students[i].Name}");
                            Console.WriteLine($"Program: {students[i].Program}");
                            Console.WriteLine($"Year Level: {students[i].YearLevel}\n");
                        }
                    }
                    break;

                case "4":
                    Console.Write("Enter Student Number to update: ");
                    string updateId = Console.ReadLine();
                    for (int i = 0; i < count; i++)
                    {
                        if (students[i].StudentNumber == updateId)
                        {
                            Console.Write("Enter New Name: ");
                            students[i].Name = Console.ReadLine();
                            Console.Write("Enter New Program: ");
                            students[i].Program = Console.ReadLine();
                            Console.Write("Enter New Year Level: ");
                            students[i].YearLevel = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nUpdated successfully!\n");
                        }
                    }
                    break;

                case "5": 
                    Console.Write("Enter Student Number to delete: ");
                    string deleteId = Console.ReadLine();
                    for (int i = 0; i < count; i++)
                    {
                        if (students[i].StudentNumber == deleteId)
                        {
                            for (int j = i; j < count - 1; j++)
                            {
                                students[j] = students[j + 1];
                            }
                            count--;
                            Console.WriteLine("\nDeleted successfully!\n");
                            break;
                        }
                    }
                    break;
            }
        }
    }
}
