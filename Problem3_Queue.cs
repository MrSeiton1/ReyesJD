using System;
using System.Collections.Generic;

public class StudentRequest
{
    public string StudentNumber { get; set; }
    public string StudentName { get; set; }
    public string RequestType { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Queue<StudentRequest> requestQueue = new Queue<StudentRequest>();

        while (true)
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("           STUDENT REQUEST QUEUE                  ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1. Add Request");
            Console.WriteLine("2. View Pending Requests");
            Console.WriteLine("3. Process Request");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                StudentRequest req = new StudentRequest();

                Console.Write("Enter Student Number: ");
                req.StudentNumber = Console.ReadLine();

                Console.Write("Enter Student Name: ");
                req.StudentName = Console.ReadLine();

                Console.Write("Enter Request Type: ");
                req.RequestType = Console.ReadLine();

                requestQueue.Enqueue(req);
                Console.WriteLine("\nRequest added successfully!\n");
            }
            else if (choice == "2")
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("\nNo pending requests.\n");
                }
                else
                {
                    Console.WriteLine("\nREQUEST QUEUE");
                    int index = 1;
                    foreach (StudentRequest req in requestQueue)
                    {
                        Console.WriteLine($"{index}. {req.StudentName} - {req.RequestType}");
                        index++;
                    }
                    Console.WriteLine();
                }
            }
            else if (choice == "3")
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("\nNo pending requests to process[cite: 2].\n");
                }
                else
                {
                    StudentRequest processedReq = requestQueue.Dequeue();
                    Console.WriteLine($"\nProcessing Request: {processedReq.StudentName} - {processedReq.RequestType}");
                    Console.WriteLine("Request processed successfully!\n");
                }
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.\n");
            }
        }
    }
}
