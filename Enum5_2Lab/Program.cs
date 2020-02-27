using System;
using System.Collections;
using System.Collections.Generic;



namespace Enum5_2Lab
{
    class Program
    {
        enum Weekdays
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }
        static void Main(string[] args)
        {
            List<string> Tasklist = new List<string>();
            
            foreach (Weekdays Day in Enum.GetValues(typeof(Weekdays)))
            
            {
                Console.WriteLine(" Type your plans for the day" + Day);
                string Task = Day + " : " + Console.ReadLine();
                Tasklist.Add(Task);
            }

           foreach (string Task in Tasklist)
            {
                Console.WriteLine(Task);
            }
           
               
            
        }
    }
}

