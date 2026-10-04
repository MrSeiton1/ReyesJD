using System;
using System.Collections.Generic;

public struct Operation
{
    public string Action;
    public string StudentName;
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> students = new Dictionary<string, string>();
        Stack<Operation> operationHistory = new Stack<Operation>();

        while (true)
        {
            Console.WriteLine("\n==================================================");
            Console.WriteLine("           OPERATION HISTORY SYSTEM               ");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Update Student");
            Console.WriteLine("3. Delete Student");
            Console.WriteLine("4. View Operation History");
            Console.WriteLine("5. View Last Operation");
            Console.WriteLine("6. Remove Last Operation");
            Console.WriteLine("7. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter Student Number: ");
                string id = Console.ReadLine();
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                students[id] = name;
                operationHistory.Push(new Operation { Action = "Added", StudentName = name });
                Console.WriteLine("\nStudent added successfully!\n");
            }
            else if (choice == "2")
            {
                Console.Write("Enter Student Number to update: ");
                string id = Console.ReadLine();

                if (students.ContainsKey(id))
                {
                    Console.Write("Enter New Name: ");
                    string name = Console.ReadLine();
                    students[id] = name;
                    operationHistory.Push(new Operation { Action = "Updated", StudentName = name });
                    Console.WriteLine("\nStudent updated successfully!\n");
                }
                else
                {
                    Console.WriteLine("Student not found.\n");
                }
            }
            else if (choice == "3")
            {
                Console.Write("Enter Student Number to delete: ");
                string id = Console.ReadLine();

                if (students.ContainsKey(id))
                {
                    string name = students[id];
                    students.Remove(id);
                    operationHistory.Push(new Operation { Action = "Deleted", StudentName = name });
                    Console.WriteLine("\nStudent deleted successfully!\n");
                }
                else
                {
                    Console.WriteLine("Student not found.\n");
                }
            }
            else if (choice == "4")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("\nNo recorded operations[cite: 3].\n");
                }
                else
                {
                    Console.WriteLine("\nOPERATION HISTORY");
                    Operation[] ops = operationHistory.ToArray();
                    for (int i = ops.Length - 1, index = 1; i >= 0; i--, index++)
                    {
                        Console.WriteLine($"{index}. {ops[i].Action} {ops[i].StudentName}");
                    }
                    Console.WriteLine();
                }
            }
            else if (choice == "5")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("\nNo recorded operations[cite: 3].\n");
                }
                else
                {
                    Operation last = operationHistory.Peek();
                    Console.WriteLine($"\nLast Operation: {last.Action} {last.StudentName}\n");
                }
            }
            else if (choice == "6")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("\nNo recorded operations to remove[cite: 3].\n");
                }
                else
                {
                    operationHistory.Pop();
                    Console.WriteLine("\nLast operation removed successfully!\n");
                }
            }
            else if (choice == "7")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.\n");
            }
        }
    }
}
