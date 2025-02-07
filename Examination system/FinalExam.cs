using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class FinalExam : Exams
    {

        
        public FinalExam(int numberOfQuestions, int examTime)
        {
            NumberOfQuestions = numberOfQuestions;
            ExamTime = examTime;
            ExamQuestion = new BaseQuestion[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                int questionType;

                Console.Write($" enter type of  Question {i + 1}  1 True|False and  2  MCQ : ");
                while (!InputHelper.ValidateInputInt( out questionType, 1))
                {
                   
                }

                ExamQuestion[i] = questionType == 1 ? new TrueOrFalseQuestion() : new MCQQuestion();
                ExamQuestion[i].SetQuestionBodyAndMark(i);
            }
        }

        public override void ShowExam()
        {
            double score = 0;
            double totalExamMarks = 0;
            Console.WriteLine("-------------------------- Final Exam -----------------");

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
                    score += ExamQuestion[i].QMark;
                }
                totalExamMarks += ExamQuestion[i].QMark;
            }

           
            Console.WriteLine($"Your Grade: {score} / {totalExamMarks}");



            Console.WriteLine("-------------------------- The Right answer for Exam  -----------------");


            for (int i = 0; i < NumberOfQuestions; i++)
            {
                if (ExamQuestion[i] == null || ExamQuestion[i].RightQuestionAnswer == null)
                {
                    continue;
                }

                Console.Write($"Question {i + 1}: {ExamQuestion[i].Qbody} :  ");
                Console.WriteLine($"Correct Answer: {ExamQuestion[i].RightQuestionAnswer.AnswerId} => {ExamQuestion[i].RightQuestionAnswer.AnswerText}");
            }
        }

        public override int GetValidAnswer(int numberOfChoices)
        {
            int studentAnswer;
            bool valid;
            do
            {
                Console.WriteLine(" enter your answer Number :  ");
                valid = int.TryParse(Console.ReadLine(), out studentAnswer);
            } while (!valid || (studentAnswer < 1 || studentAnswer > 3));

            return studentAnswer;
        } 
        
    }
}
