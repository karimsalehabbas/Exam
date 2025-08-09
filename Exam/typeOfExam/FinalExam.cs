using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.typeOfExam
{
    class FinalExam:Exam
    {

        #region Constractor
        public FinalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
        }
        #endregion
        #region Override AddQustion Method
        public override void AddQuestion()
        {
            for (int i = 1; i <= NumberOfQuestions; i++)
            {
                Question question;

                Console.WriteLine($"Enter details for Question {i} :");

                Console.Write("Enter Question Body : ");
                string body = Console.ReadLine();

                Console.Write("Enter Question Mark : ");
                int mark = int.Parse(Console.ReadLine());

                Console.Write("Enter The Type  question Number  (1 for True or False)|| 2 for MCQ question? :");
                int choose = int.Parse(Console.ReadLine());

                if (choose == 1)
                {
                    question = new TrueFalseQuestion(body, mark);
                    Console.Write("Enter The Correct Answer (True or False): ");
                    string correctAnswer = Console.ReadLine();
                    if (correctAnswer.Equals("true"))
                    {
                        question.AnswerList.Add(new Answer(1, "True"));
                        question.AnswerList.Add(new Answer(2, "False"));
                        question.CorrectAnswer = 1;
                    }
                    else
                    {
                        question.AnswerList.Add(new Answer(1, "True"));
                        question.AnswerList.Add(new Answer(2, "False"));
                        question.CorrectAnswer = 2;
                    }

                    Questions[i - 1] = question;

                }
                else if (choose == 2)
                {
                    question = new MCQQuestion(body, mark);
                    for (int j = 1; j <= 4; j++)
                    {
                        Console.Write($"Enter Answer choice {j}: ");
                        string answerText = Console.ReadLine();
                        question.AnswerList.Add(new Answer(j, answerText));
                    }
                    Console.Write("Enter The Correct Answer (1-4): ");
                    int correctAnswerIndex = int.Parse(Console.ReadLine());
                    question.CorrectAnswer = correctAnswerIndex;
                    Questions[i - 1] = question;
                }

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
