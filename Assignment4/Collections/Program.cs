Write a program to find the Sum and the Average points scored by the teams in the IPL. 
Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches) 
that takes no.of matches as input and accepts that many scores from the user. 
The function should then display the Average and Sum of the scores

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Cricket
    {
        ArrayList scores = new ArrayList();

        public void PointsCalculation(int no_of_matches)
        {
            int total = 0;
            double avg;
            Console.Write("Enter the scores:");
            for (int i = 0; i < no_of_matches; i++)
            {
                scores.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (int item in scores)
            {
                total += item;
            }
            avg = total / no_of_matches;

            Console.WriteLine($"The total runs scored by the batsman in {no_of_matches} matches: {total}");
            Console.WriteLine($"The Average of the batsman in this season is {avg}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        { 
            Cricket cric = new Cricket();
            Console.Write("Enter the number of matches ");
            int no = Convert.ToInt32(Console.ReadLine());
            cric.PointsCalculation(no);
        }
    }
}
