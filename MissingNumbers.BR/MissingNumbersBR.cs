using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissingNumbers.BR
{
    public class MissingNumbersBR
    {
        public string Run()
        {
            try
            {
                InputValidation.PrintInitialMessage();
                int n = InputValidation.ValidateInputOnlyNumbers("n");
                InputValidation.ValidateN(n);
                Console.Write("Enter 'arr':   ");
                int[] arr = InputValidation.ValidateArrays(Console.ReadLine().Split(' '), n);
                int m = InputValidation.ValidateInputOnlyNumbers("m");
                InputValidation.ValidateN(m);
                InputValidation.ValidateDimensions(n, m);
                Console.Write("Enter 'brr':   ");
                int[] brr = InputValidation.ValidateArrays(Console.ReadLine().Split(' '), m);

                return FindMissingNumbers(arr, brr);
            }
            catch (Exception ex)
            {
                return InputValidation.ManageException(ex);
            }
        }

        private string FindMissingNumbers(int[] arr, int[] brr)
        {
            List<int> arrList = arr.ToList();
            List<int> brrList = brr.ToList();
            InputValidation.ValidateMaxMin(brrList);
            List<int> responseList = new List<int>();
            foreach (var brrItem in brrList)
                ValidateMissingNumbers(responseList, brrList, arrList, brrItem);

            return PrintListMissingNumbers(responseList.OrderBy(x => x).ToList());
        }

        private void ValidateMissingNumbers(List<int> responseList, List<int> brrList, List<int> arrList, int brrItem)
        {
            if (!arrList.FindAll(x => x == brrItem).Any())
                responseList.Add(brrItem);
            if (brrList.FindAll(x => x == brrItem).Count != arrList.FindAll(x => x == brrItem).Count && !responseList.Contains(brrItem))
                responseList.Add(brrItem);
        }

        private string PrintListMissingNumbers(List<int> missingNumbers)
        {
            StringBuilder missingNumbersResponse = new StringBuilder();
            missingNumbersResponse.Append("\n****************************\n");
            missingNumbersResponse.Append("\nMissing Numbers:\n");
            foreach (var item in missingNumbers)
            {
                missingNumbersResponse.Append(" ");
                missingNumbersResponse.Append(item);
            }
            return missingNumbersResponse.ToString();
        }
    }
}