using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.typeOfExam
{
    class PracticalExam : Exam
    {

        #region Constractor
        public PracticalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
        }
        #endregion

        #region Override AddQuestion Method
        public override void AddQuestion()
        {
            for (int i = 1; i <= NumberOfQuestions; i++)
            {

                Console.WriteLine($"Enter details for Question {i} :");
                Console.Write("Enter Question Body : ");
                string body = Console.ReadLine();

                Console.Write("Enter Question Mark : ");
                int mark = int.Parse(Console.ReadLine());

                Question question = new MCQQuestion(body, mark);
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write($"Enter Answer choice {j} : ");
                    string answerText = Console.ReadLine();
                    question.AnswerList.Add(new Answer(j, answerText));
                }
                Console.Write("Enter The Correct Answer (1-4) : ");
                int correctAnswerIndex = int.Parse(Console.ReadLine());
                question.CorrectAnswer = correctAnswerIndex;
                Questions[i - 1] = question;
            }
            Console.Clear();
        }
        #endregion
        #region Override ShowExam Method
        public override void ShowExam()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine($"Question [{i + 1}] : {Questions[i].Body}");

                for (int j = 0; j < Questions[i].AnswerList.Count; j++)
                {
                    Console.Write($"{Questions[i].AnswerList[j].AnswerId}- {Questions[i].AnswerList[j].AnswerText}   ");
                }
                Console.WriteLine();
                Console.WriteLine("Choose The Number  of Correct Answer : ");
                int number = int.Parse(Console.ReadLine());
                if (number == Questions[i].CorrectAnswer)
                    Grade += Questions[i].Mark;
                Console.Clear();

            }

        }
        #endregion

    }
}
