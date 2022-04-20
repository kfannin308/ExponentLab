using System;

namespace ExponentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Enter an integer between 1 and 1290");
                string myString = Console.ReadLine();
                bool isAnInt = int.TryParse(myString, out int myInt);

                if (isAnInt && myInt > 0 && myInt <= 1290)
                {
                    
                    Console.WriteLine("Number\t      Squared\t      Cubed");
                    Console.WriteLine("======\t      =======\t      =====");
                    
                    for (int x = 0; x < myInt; x++)
                    {
                        int num = x + 1;
                        int intSquared = num * num;
                        int intCubed = num * num * num;
                        string strNum = num.ToString();
                        string strSquared = intSquared.ToString();
                        string strCubed = intCubed.ToString();
                        string numRight = strNum.PadLeft(6);
                        string squaredRight = strSquared.PadLeft(7);
                        string cubedRight = strCubed.PadLeft(10);

                        Console.WriteLine($"{numRight} \t      {squaredRight} \t {cubedRight}"); 
                    }                 
                }
                else { Console.WriteLine("Invalid Number"); cont = false; }
                
                Console.WriteLine("Do you want to continue?: (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y") { cont = true; }
                else { cont = false; }
            } 
        }
    }
}
