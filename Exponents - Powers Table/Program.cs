using System;

namespace Exponents___Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again == true)
            {
                bool validNum = false;
                while (validNum == false)
                {
                    Console.WriteLine("Please enter an integer: ");
                    int userNum = int.Parse(Console.ReadLine());
                    int square = userNum;
                    int cubed = userNum;
                    int i;

                    if (userNum < 1 || userNum > 1289)
                    {
                        Console.WriteLine("Must be a postive number above zero. Try again");
                        validNum = false;
                    } 
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Number \t \t squared \t cubed");
                        Console.WriteLine("========================================");
                        for (i = 1; i <= userNum; i++)
                        {
                            square = i * i;
                            cubed = i * i * i;
                            Console.WriteLine($"  {i} \t  \t    {square} \t \t   {cubed}");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                        validNum = true;
                    }
                }

                again = GoAgain();
            }
            

        }

        public static bool GoAgain()
        {
            Console.WriteLine("Would you like to continue? Y/N ");
            string input = Console.ReadLine();

            if(input.ToUpper() == "Y" || input.ToUpper() == "YES")
            {
                return true;
            } 
            else if(input.ToUpper() == "N" || input.ToUpper() == "NO")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Must input a valid response. Y/N: ");
                return GoAgain();
            }
        }
    }
}
