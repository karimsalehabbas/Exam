using Exam.typeOfExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Subject
    {

        #region Property
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam exam { get; set; }
        #endregion

        #region Constractor
        public Subject(int _subjectId, string _subjectName)
        {
            SubjectId = _subjectId;
            SubjectName = _subjectName;
        }
        #endregion

        #region CreateExam FuncTion
        public void CreateExam()
        {
            Console.Write("Enter the Type of exam (Final/Practical): ");
            string examType = Console.ReadLine();
            bool isFinalExam = examType.Equals("Final", StringComparison.OrdinalIgnoreCase);
            Console.Write("Enter Time of Exam: ");
            int timeOfExam = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Questions: ");
            int numberOfQuestions = int.Parse(Console.ReadLine());
            Console.Clear();
            if (examType.Equals("final"))
            {
                exam = new FinalExam(timeOfExam, numberOfQuestions);
                exam.AddQuestion();
            }
            else
            {
                exam = new PracticalExam(timeOfExam, numberOfQuestions);
                exam.AddQuestion();
            }
        }
        #endregion


    }
}
