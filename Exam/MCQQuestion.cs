using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class MCQQuestion : Question
    {

        #region Property
        public List<Answer> Answers { get; set; }
        #endregion

        #region Constractor
        public MCQQuestion(string body, int mark) : base(body, mark)
        {
            Answers = new List<Answer>();
        }
        #endregion

    }
}
