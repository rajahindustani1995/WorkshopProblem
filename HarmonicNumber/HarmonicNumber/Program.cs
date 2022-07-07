using System;

namespace HarmonicNumber
{
    class Harmonic
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Nth number to get Harmonic Number : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            double harmonicNumber = 0;

            if (Number > 0)
            {
                for (double i = 1; i <= Number; i++)
                {
                    harmonicNumber += 1 / i;
                }
                Console.WriteLine(Number + "th harmonic number is : " + harmonicNumber);
                
               
            }
            else
            {
                Console.WriteLine("Enter valid data : ");
            }
            


        }
    }
}
