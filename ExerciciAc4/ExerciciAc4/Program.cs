using System;
namespace Ac4
{
    // Ex2
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceFirstNumber = "Introdueix el primer número: ";
            const string MsgIntroduceSecondNumber = "Introdueix el segon número: ";
            const string MsgIntroduceThirdNumber = "Introdueix el tercer número: ";
            const string MsgError = "Error. El valor ha de ser un enter.";
            const string MsgResult = "El número més gran és: {0}";

            int numOne = 0;
            int numTwo = 0;
            int numThree = 0;

            Console.WriteLine(MsgIntroduceFirstNumber);
            while (!int.TryParse(Console.ReadLine(), out numOne))
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            Console.WriteLine(MsgIntroduceSecondNumber);
            while (!int.TryParse(Console.ReadLine(), out numTwo))
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            Console.WriteLine(MsgIntroduceThirdNumber);
            while (!int.TryParse(Console.ReadLine(), out numThree))
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            Console.WriteLine(MsgResult, WhichIsBigger(numOne, numTwo, numThree));
        }

        public static int WhichIsBigger(int numOne, int numTwo, int numThree)
        {
            int biggestNumber = 0;

            if (numOne > numTwo && numOne > numThree)
            {
                biggestNumber = numOne;
            } 
            else if (numTwo > numOne && numTwo > numThree)
            {
                biggestNumber = numTwo;
            }
            else
            {
                biggestNumber = numThree;
            }

            return biggestNumber;
        }
    }
}
