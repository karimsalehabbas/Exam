using System.Diagnostics;
using System.Numerics;
namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to The Examination System ");


            Subject subject = new Subject(1, "C#");

            subject.CreateExam();

            Console.Write("Do you want to start the exam? (yes/no): ");
            string startExam = Console.ReadLine();
            Console.Clear();

            if (startExam.ToLower() == "yes")
            {
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();

                subject.exam.ShowExam();
                Console.WriteLine($"Your Grade is {subject.exam.Grade}");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Exam Not started ");
            }

        }
    }
}
