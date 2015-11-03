using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void SampleDelegate();
public delegate void SampleDelegate1(out int Number);

namespace MultiCastDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate samp4, samp1, samp2, samp3, samp5;
            SampleDelegate del1 = new SampleDelegate(SampleMethodOne);
            del1 += SampleMethodTwo;
            del1();

            samp1 = new SampleDelegate(SampleMethodOne);
            samp2 = new SampleDelegate(SampleMethodTwo);
            samp3 = new SampleDelegate(SampleMethodThree);
            samp5 = new SampleDelegate(SampleMethodFour);

            samp4 = samp1 + samp2 + samp3 + samp5 - samp1;

            samp4();

            Console.WriteLine("------------");
            SampleDelegate1 Sdel1 = new SampleDelegate1(SampleMOne);
            Sdel1 += SampleMTwo;

            int DelegateRetValue ;
            Sdel1(out  DelegateRetValue);
            Console.WriteLine("Value of Delegate {0}", DelegateRetValue);

 
            Console.ReadLine();

        }

        public static void SampleMOne(out int Number)
        {
            Number = 1;
        }
        public static void SampleMTwo(out int Number)
        {
            Number = 2;
        }
        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }
        public static void SampleMethodFour()
        {
            Console.WriteLine("SampleMethodFour - Invoked");
        }
    }
}
