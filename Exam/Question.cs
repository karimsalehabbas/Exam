using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Question
    {

        #region Property
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> AnswerList { get; set; }

        public int CorrectAnswer { get; set; }
        #endregion

        #region Constractor
        public Question(string body, int mark)
        {

            Body = body;
            Mark = mark;
            AnswerList = new List<Answer>();

        }
        #endregion


        #region Method
        public virtual void Display()
        {

            Console.WriteLine($"Body:   {Body}");
            Console.WriteLine($"Mark:   {Mark}");
        }
        #endregion

    }
}
