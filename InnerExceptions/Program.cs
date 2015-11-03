using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter First Number ");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number ");
                int SN = Convert.ToInt32(Console.ReadLine());

                int Result = FN / SN;
                Console.WriteLine("Result = {0} ", Result);

                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please Try Again");
            }

        }
       
    }
}
