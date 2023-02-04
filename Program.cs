using System;

namespace MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exam E = new PracticeExam();        //just for initialization

            #region Choose the Exam
            //Type of Exam
            int ex;
            Console.WriteLine("Please choose the type of exam \n1- Practice Exam \n2- Final Exam");
            do {
                int.TryParse(Console.ReadLine(), out ex);
                if(ex != 1 && ex != 2) Console.WriteLine("Invalid Choice"); 
            }
            while (ex != 1 && ex != 2);

            if (ex == 1) { E = new PracticeExam(); }
            else { E = new FinalExam(); }

            //Number of Questions
            int n;
            do {Console.WriteLine("Please enter number of questions");} 
            while (!int.TryParse(Console.ReadLine(), out  n));
            
            E.Time = "1 Hour";
            E.NoQ = n;
            E.ShowType();
            E.Q = new Question[n];
            #endregion

            #region Set the Questions

            for (int i = 0; i < n; i++)
            {
                int q;
                do
                {
                    Console.WriteLine("Please choose the type of question from 1 to 3" +
                    "\n1- True or False \n2- Choose One only \n3- Choose All right answers");
                    int.TryParse(Console.ReadLine(), out q);
                    if (q != 1 && q != 2 && q != 3) Console.WriteLine("Invalid Choice");

                } while (q != 1 && q!= 2 && q != 3);

                
                if (q == 1) { E.Q[i] = new Q_TorF(); }
                else if (q == 2) { E.Q[i] = new Q_ChooseOne(); }
                else E.Q[i] = new Q_ChooseAll();

                Console.WriteLine($"\nPlease enter the Header of Q {i + 1}");
                E.Q[i].Header = Console.ReadLine();
                Console.WriteLine($"Please enter the Body of Q {i + 1}");
                E.Q[i].Body = Console.ReadLine();
                Console.WriteLine($"Please enter the Mark of Q {i + 1}");
                E.Q[i].Mark = Convert.ToInt32(Console.ReadLine());

                E.Q[i].display();

                if (ex == 1)
                {
                    Console.WriteLine("Please enter the Model answer");
                    E.Q[i].A.Body = Console.ReadLine();
                    Console.WriteLine("\n-----------------------------------\n");
                }
                else Console.WriteLine("This is Final Exam, So Student Should answer it");


            }
            #endregion

            //Show The Body of Questions and answers
            E.Display();
        }

    }
}
