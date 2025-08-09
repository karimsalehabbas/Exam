using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Answer
    {

        #region Property
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        #endregion

        #region Constractor
        public Answer(int _answerId, string _answerText)
        {
            AnswerId = _answerId;
            AnswerText = _answerText;
        }
        #endregion

    }
}
