using System;
using static System.Console;

/*  Author:         Patrick McDevitt
 *  Date:           1/28/2024
 *  Description:    You Do IT excercises Chapter 11
 *  Resources:
 */

namespace CSC240_04_01_ExceptionsOnPurpose_pmm
{
    class ExceptionsOnPurpose
    {
        static void Main(string[] args)
        {
            // STORAGE
            int answer;
            int result;
            int zero = 0;                  
            
            // Input
            Write("Enter an integer >> ");
            answer = Convert.ToInt32(ReadLine());
            // Process
            result = answer / zero;
            // Output
            WriteLine("The answer is " + answer);
        }
    }
}
