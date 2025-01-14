using System;
namespace Ac4
{
    // Ex1
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceNumber = "Introdueix un número enter: ";
            const string MsgError = "Error. El valor ha de ser un número enter.";
            const string MsgOk = "El valor introduït està dins el rang [5-100].";
            const string MsgKo = "EL valor introduït no està dins el rang [5-100].";

            int numberInput = 0;

            Console.WriteLine(MsgIntroduceNumber);
            while (!int.TryParse(Console.ReadLine(), out numberInput))
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            Console.WriteLine(IsInRange(numberInput) ? MsgOk : MsgKo);
        }

        public static bool IsInRange(int numberInput)
        {
            const int MaxRange = 100;
            const int MinRange = 5;

            return numberInput <= MaxRange && numberInput >= MinRange;
        }

    }
}
