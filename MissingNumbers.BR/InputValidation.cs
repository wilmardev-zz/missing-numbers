using System;

namespace MissingNumbers.BR
{
    public static class InputValidation
    {
        public static void ValidateN(int number)
        {
            if (number > (Math.Pow(10, 5) * 2))
                Console.WriteLine(">> ERROR: number is greater than 2x10^5");
        }

        public static string ManageException(Exception exception)
        {
            string msgErrorLargeInt = "Value was either too large or too small for an Int32.";
            if (exception.Message.ToLower().Contains(msgErrorLargeInt.ToLower()))
                return ">> ERROR: Value was either too large.... Is greater than 10^5";

            return ">> ERROR: Something went wrong.";
        }

        public static void PrintInitialMessage()
        {
            Console.WriteLine("Welcome to Missing Numbers");
            Console.WriteLine("Constraints:\n");
            Console.WriteLine("* 1 <= n, m <= 2x10^5");
            Console.WriteLine("* n <= m");
            Console.WriteLine("* 1 <= brr[i] <= 10^4");
        }
    }
}