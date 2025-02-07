using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public class Subject
    {



        public Exams exam { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public void CreateExam()
        {
            int examType;
            int numberOfQuestions;
            int timeOfExam;

            do
            {
                Console.Write("enter exam type : 1 for Practical | 2 for Final : ");
            } while (!InputHelper.ValidateInputInt(out examType, 1) || examType > 2);

            Console.WriteLine($"Enter the number of questions: ");
            while (!InputHelper.ValidateInputInt(out numberOfQuestions, 1))
            {
            }

            Console.WriteLine("enter the time for the exam: ");
            while (!InputHelper.ValidateInputInt(out timeOfExam, 1))
            {

            }
            // this is first way to check the exam type 
            if (examType == 1)
            {
                exam = new PracticalExam(numberOfQuestions, timeOfExam);
            }
            else
            {
                exam = new FinalExam(numberOfQuestions, timeOfExam);
            }


            // this is second way by use the Switch expression 
            /*
             exam = examType switch
             {

                 1 => new PracticalExam(numberOfQuestions, timeOfExam),
                 2 => new FinalExam(numberOfQuestions, timeOfExam),
             };
            */

        }





        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

    }
}
