using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public abstract class BaseQuestion
    {
        public string? QHeader { get; set; }
        public string? Qbody { get; set; }
        public double QMark { get; set; }
        public Answers[] QuestionAnswer { get; set; }
        public Answers RightQuestionAnswer { get; set; }

        public abstract void SetQuestionBodyAndMark(int numberOfQuestion);

    }
}
