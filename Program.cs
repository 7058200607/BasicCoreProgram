﻿using System;
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
            Console.WriteLine("Enter A Choice :");
            Console.WriteLine("0.Flip the Coin Program");
            Console.WriteLine("1.Leap Year Program");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    FlipCoin.AFlipCoin();
                    break;
                case 1:
                    LeapYear.ALeapYear();
                    break;

            }
            


        }

    }

}

   