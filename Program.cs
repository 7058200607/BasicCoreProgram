using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasicCoreProgram
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("0.Flip the Coin Program");
            Console.WriteLine("1.Leap Year Program");
            Console.WriteLine("2.Find Quotient And Remainder");
            Console.WriteLine("3.Swap A Given Number");
            Console.WriteLine("4.Number is Even Or Odd");
            Console.Write("Enter A Choice :");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    FlipCoin.AFlipCoin();
                    break;
                case 1:
                    LeapYear.ALeapYear();
                    break;
                case 2:
                    QuotientAndRemainder.AQuotientAndRemainder();
                    break;
                case 3:
                    SwapANumber.ASwapNumber();  
                    break;
                case 4:
                    EvenOrOddNumber.AEvenOddNumber();
                    break;


            }
            


        }

    }

}

   
