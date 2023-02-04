using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body{ get; set; }
        public int Mark { get; set; }
        public void display() { Console.WriteLine($"Header: {Header}\nBody: {Body}\t\t{Mark} Marks"); }
        public Answer A;
    }
    internal class Q_TorF: Question
    {
        public Q_TorF()
        {
            A = new A_TorF();
        }
    }
    internal class Q_ChooseOne : Question
    {
        public Q_ChooseOne()
        {
            A = new A_ChooseOne();
        }
    }
    internal class Q_ChooseAll : Question
    {
        public Q_ChooseAll()
        {
            A = new A_ChooseAll();
        }
    }
}
