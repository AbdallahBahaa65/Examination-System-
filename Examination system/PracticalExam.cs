using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public class PracticalExam : Exams
    {



        public PracticalExam(int numberOfQuestions, int examTime)
        {
            NumberOfQuestions = numberOfQuestions;
            ExamTime = examTime;
            ExamQuestion = new BaseQuestion[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                ExamQuestion[i] = new MCQQuestion();
                ExamQuestion[i].SetQuestionBodyAndMark(i);
            }
        }

        public override void ShowExam()
        {
            double score = 0;
            double totalExamMarks = 0;


            Console.WriteLine("-------------------------- Practical Exam -----------------");


            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine($"Question {i + 1}: {ExamQuestion[i].Qbody} ({ExamQuestion[i].QMark} Mark");

                for (int j = 0; j < ExamQuestion[i].QuestionAnswer.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {ExamQuestion[i].QuestionAnswer[j].AnswerText}");
                }

                int studentAnswer = GetValidAnswer(ExamQuestion[i].QuestionAnswer.Length);
                if (studentAnswer == ExamQuestion[i].RightQuestionAnswer.AnswerId)
                {
                    score += ExamQuestion[i].QMark; // this for if we need to print the grad in future 
                }
                totalExamMarks += ExamQuestion[i].QMark;
            }




            Console.WriteLine("-------------------------- The Right answer for Exam  -----------------");



            for (int i = 0; i < NumberOfQuestions; i++)
            {
                if (ExamQuestion[i] == null || ExamQuestion[i].RightQuestionAnswer == null)
                {
                    continue;
                }

                Console.Write($"Question {i + 1}: {ExamQuestion[i].Qbody}  :  ");
                Console.WriteLine($"Right Answer: {ExamQuestion[i].RightQuestionAnswer.AnswerId} => {ExamQuestion[i].RightQuestionAnswer.AnswerText}");
            }
        }




        public override int GetValidAnswer(int numberOfChoices)
        {
            int studentAnswer;
            bool valid;
            do
            {
                Console.WriteLine(" enter your answer Number 1 , 2, 3  :  ");
                valid = int.TryParse(Console.ReadLine(), out studentAnswer);

            } while (!valid || (studentAnswer < 1 || studentAnswer > 3));

            return studentAnswer;
        }


    }
}
