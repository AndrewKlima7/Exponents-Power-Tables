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
                    validNum = GetNum();
                }

                again = GoAgain();
            }


        }

        public static bool GoAgain()
        {
            Console.Write("Would you like to continue? Y/N ");
            string input = Console.ReadLine();

            if (input.ToUpper() == "Y" || input.ToUpper() == "YES")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                return true;
            }
            else if (input.ToUpper() == "N" || input.ToUpper() == "NO")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Must input a valid response.");
                return GoAgain();
            }
        }

        public static bool GetNum()
        {
            Console.Write("Please enter an integer: ");
            int userNum = int.Parse(Console.ReadLine());
            int square = userNum;
            int cubed = userNum;
            int i;

            if (userNum < 1 || userNum > 1289)
            {
                Console.WriteLine("Must be a postive number above zero. Try again");
                Console.WriteLine("");
                Console.WriteLine("");
                return false;
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
                return true;
            }
        }
    }
}
