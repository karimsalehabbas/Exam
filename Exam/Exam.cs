using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    abstract class Exam
    {

        #region Property
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }

        public Question[] Questions { get; set; }

        public int Grade { get; set; }
        #endregion


        #region Constractor
        public Exam(int _timeOfExam, int _numberOfQuestions)
        {
            TimeOfExam = _timeOfExam;
            NumberOfQuestions = _numberOfQuestions;

            Questions = new Question[_numberOfQuestions];
        }
        #endregion


        #region abstract Method => AddQuestion()
        public abstract void AddQuestion();
        #endregion

        #region abstract Method => ShowExam()
        public abstract void ShowExam();
        #endregion

    }
}
