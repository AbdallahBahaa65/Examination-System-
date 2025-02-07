using System.Diagnostics;

namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exam_code 
            Subject s1 = new Subject(10, "C#");
            s1.CreateExam();
            Console.Clear();

            Console.WriteLine("are you need to startexam y | n ");
            if (char.Parse(Console.ReadLine()) == 'y')
            {

                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();
                s1.exam.ShowExam();
                Console.WriteLine($" the Elapsed time = {sw.Elapsed}");
            }
            else
                Console.WriteLine("------------------------- ::::::: You Are Welcome  :::::::: -----------------------------");

            #endregion
        }
    }
}
