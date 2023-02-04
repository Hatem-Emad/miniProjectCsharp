using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    public abstract class Answer
    {
        public abstract string Body { get; set; }
        public void display() { Console.WriteLine(Body); }
    }
    public class A_TorF : Answer
    {
        public override string Body { get; set; }
    }
    public class A_ChooseOne : Answer
    {
        public override string Body { get; set; }
    }
    public class A_ChooseAll : Answer
    {
        public override string Body { get; set; }
    }
}
