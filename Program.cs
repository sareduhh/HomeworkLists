using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLists
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create the following list:
	           List<bool> boolList = new List<bool>() { true, false, false,  true, false};
               Loop through each value
               If the value is true print:    "Better bring an umbrella"
               If the value is false print:  "No rain today, enjoy the sun!"*/

       List<bool> boolList = new List<bool>() { true, false, false, true, false };
            foreach (bool currentVal in boolList)
            {
                if (currentVal == true)
                {
                    Console.WriteLine("Better bring an umbrella.");
                }
                else
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }
            }
        }
    }
}
