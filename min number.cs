using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCod 
{

    internal class min_number
    {
         static void main(String[] args)
        {
            int[] larr1 = new int[5];
            Console.WriteLine("enter value for 5 integer");

            for (int i = 0; i < larr1.Length; i++)
            {
                larr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int mini = larr1 [0];
            for (int i = 0; i < 5; i++)
            {
                if (mini > larr1[i])
                {
                    mini = larr1[i];
                }
            }
            Console.WriteLine("THE mini value :" + mini);
        }


}   }