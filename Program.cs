﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int

            //MAIN CHALLENGE: WRITE A PROGRAM TO CONVERT ANY INTEGER TO ITS EQUIVALENT BINARY NUMBER
            /*
            Start
            string binarynum;
            OUTPUT "type in integer"
            int userint = INPUT
            while userint !=0
                userint = userint/2
                binarynum = binarynum + "1"
            OUTPUT !binarynum
            */
            
            //WRITE A CALL TO YOUR NUMBER CONVERSION FUNCTION HERE
            static string numberConverter()
            {
                            string binarynum = "";
                            Console.WriteLine("type in your integer");
                            int userint = Convert.ToInt32(Console.ReadLine());
                            while (userint > 0)
                            {
                                if (userint % 2 == 0)
                                {
                                    binarynum = "0" + binarynum;
                                }
                                else
                                {
                                    binarynum = "1" + binarynum;
                                }
                                userint = userint / 2;
                            }
                            Console.WriteLine(binarynum);

            }
            
        }

        // LET'S USE THE 'STRUCTURED APPROACH' TO PROGRAMMING...A QUICK INTRODUCTION TO SUBBROUTINES(functions and procedures)...a.k.a. 'methods' in C#
        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            //CODE GOES HERE

            return result; //REMOVE THE RED LINE!
        }
       
    }
}
