using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public class TrueOrFalseQuestion : BaseQuestion
    {


        public TrueOrFalseQuestion()
        {
            QuestionAnswer = new Answers[2];
            QuestionAnswer[0] = new Answers(1, "True");
            QuestionAnswer[1] = new Answers(2, "False");
        }

        public override void SetQuestionBodyAndMark(int numberOfQuestion)
        {
            string questionBody;
            double questionMark;
            int correctAnswerId;

            do
            {
                Console.WriteLine($"enter the Question {numberOfQuestion + 1} Body: ");
                questionBody = Console.ReadLine();
            } while (string.IsNullOrEmpty(questionBody));

            Qbody = questionBody;

            Console.WriteLine($"enter the Question {numberOfQuestion + 1} Mark: ");
            while (!InputHelper.ValidateInputDouble(out questionMark, 1))
            {
            }
            QMark = questionMark;

            Console.Write($"enter the Correct Answer for Question {numberOfQuestion + 1} : 1  True and  2  False : ");
            while (!InputHelper.ValidateInputInt(out correctAnswerId, 1) || correctAnswerId > 2)
            {
                Console.Write($" Correct Answer for Question Must be  {numberOfQuestion + 1} : 1 for  True or   2  False : ");
            }
            RightQuestionAnswer = QuestionAnswer[correctAnswerId - 1];
        }

    }
}
