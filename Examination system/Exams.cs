using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
     public abstract  class Exams
    {
        public int ExamTime { get; set; }   
        public int NumberOfQuestions { get; set; }

        public BaseQuestion[] ExamQuestion { get; set; }

        public abstract void ShowExam();
        public abstract int GetValidAnswer(int numberOfChoices);



    }
}
