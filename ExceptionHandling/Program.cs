using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader;
            try
            {

                streamReader  = new StreamReader(@"C:\Test\Data.txt");

                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();

                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.FileName);
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine(" Finally Block");
            }
           Console.ReadLine();
        }
    }
}
