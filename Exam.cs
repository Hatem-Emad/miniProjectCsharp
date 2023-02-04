using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    internal abstract class Exam
    {
        public abstract void ShowType();
        public string Time { get; set; }
        public int NoQ { get; set; }
        public Question[] Q { get; set; }
        public void Display()
        {
            for (int i = 0; i < Q.Length; i++) { 
                Console.WriteLine(Q[i].Body);
                Console.WriteLine(Q[i].A.Body);
            }
        }

    }
    internal class FinalExam : Exam
    {
        public override void ShowType()
        {
            Console.WriteLine($"This is the Final Exam time:{Time} Number of Questions:{NoQ}");
        }       
    }
    internal class PracticeExam : Exam
    {
        public override void ShowType()
        {
            Console.WriteLine($"This is just a Practice Exam time:{Time} Number of Questions: {NoQ}");
        }
    }
}
