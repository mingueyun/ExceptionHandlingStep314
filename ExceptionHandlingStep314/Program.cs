using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingStep314
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctAge = false;
            int HowOld = 0;
            try
            {
                
                while (!correctAge)
                {
                    Console.WriteLine("What is your age?\n");
                    correctAge = int.TryParse(Console.ReadLine(), out HowOld);
                    if (!correctAge) Console.WriteLine("thats not what i was asking.");
                }
                if (HowOld <= 0 )
                {
                    Console.WriteLine(" you have entered your age as 0 or a negative value.. you are not born yet. ");
                    Console.ReadLine();
                    
                }
                else
                {

                    Console.WriteLine("you are {0} years old ", HowOld);
                    Console.WriteLine(DateTime.Now.AddYears(-HowOld).ToString("You were born in " + "yyyy"));
                    Console.ReadLine();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
