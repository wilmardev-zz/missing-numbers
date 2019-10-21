using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissingNumbers.BR
{
    public static class InputValidation
    {
        public static int ValidateInputOnlyNumbers(string input)
        {
            bool isValid = false;
            int number = -1;
            Console.Write($"Enter '{input}':   ");
            while (!isValid)
            {
                string inputUser = Console.ReadLine();
                if (int.TryParse(inputUser, out _) && Convert.ToInt32(inputUser) > 0)
                {
                    isValid = true;
                    number = Convert.ToInt32(inputUser);
                }
                else
                    Console.Write($"Enter '{input}':   ");
            }
            return number;
        }

        public static void ValidateMaxMin(List<int> brrList)
        {
            int min = brrList.Min();
            int max = brrList.Max();
            if ((max - min) > 101)
                throw new Exception(">> ERROR: The difference between maximum and minimum number in the second list must be less than 100");
        }

        public static int[] ValidateArrays(string[] array, int maxLength)
        {
            if (maxLength != array.Length)
                throw new Exception(">> ERROR: the dimensions do not match. Please Restart program!");
            int[] vector = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse(array[i], out _) && Convert.ToInt32(array[i]) > 0)
                    vector[i] = Convert.ToInt32(array[i]);
                else
                    throw new Exception(">> ERROR: Only accept numbers. Please Restart program!");
            }
            return vector;
        }

        public static void ValidateDimensions(int n, int m)
        {
            if (n <= 0 || m <= 0)
                throw new Exception(">> ERROR: number is less than 1");
            if (m < n)
                throw new Exception(">> ERROR: 'm' must be >= 'n'");
        }

        public static void ValidateN(int number)
        {
            if (number <= 0)
                throw new Exception(">> ERROR: number is less than 1");
            if (number > (Math.Pow(10, 5) * 2))
                throw new Exception(">> ERROR: number is greater than 2x10^5");
        }

        public static string ManageException(Exception exception)
        {
            string msgErrorLargeInt = "Value was either too large or too small for an Int32.";
            if (exception.Message.ToLower().Contains(msgErrorLargeInt.ToLower()))
                return ">> ERROR: Value was either too large.... Is greater than 2x10^5";
            if (!string.IsNullOrEmpty(exception.Message))
                return exception.Message;

            return ">> ERROR: Something went wrong. Please Restart program!";
        }

        public static void PrintInitialMessage()
        {
            StringBuilder message = new StringBuilder();
            message.Append("\n****************************\n");
            message.Append("\nWelcome to Missing Numbers\n\n");
            message.Append("Constraints:\n");
            message.Append("* 1 <= n, m <= 2x10^5\n");
            message.Append("* n <= m\n");
            message.Append("* 1 <= brr[i] <= 10^4\n");
            message.Append("* Xmax - Xmin < 101\n");
            message.Append("\n****************************\n");
            Console.WriteLine(message);
        }
    }
}