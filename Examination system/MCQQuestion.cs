using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public class MCQQuestion : BaseQuestion
    {



        public MCQQuestion()
        {
            QuestionAnswer = new Answers[3];
        }

        public override void SetQuestionBodyAndMark(int numberOfQuestion)
        {
            string questionBody;
            double questionMark;
            int correctAnswerId;

            do
            {
                Console.WriteLine($"enter  Question {numberOfQuestion + 1} Body: ");
                questionBody = Console.ReadLine();
            } while (string.IsNullOrEmpty(questionBody));

            Qbody = questionBody;

            Console.WriteLine($"enter  Question {numberOfQuestion + 1} Mark : ");
            while (!InputHelper.ValidateInputDouble(out questionMark, 1))
            {
            }
            QMark = questionMark;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"enter the answer Choice {i + 1} : ");
                QuestionAnswer[i] = new Answers(i + 1, Console.ReadLine() ?? string.Empty);
            }

            Console.WriteLine($"enter the Correct answer Number for Question {numberOfQuestion + 1} : ");
            while (!InputHelper.ValidateInputInt(out correctAnswerId, 1) || correctAnswerId > 3)
            {
                Console.WriteLine($"the Correct answer Number for Question   {numberOfQuestion + 1}  must be number between 1,2,3 : ");

            }
            RightQuestionAnswer = QuestionAnswer[correctAnswerId - 1];
        }

    }
}
