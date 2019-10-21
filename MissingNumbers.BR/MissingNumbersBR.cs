using System;
using System.Collections.Generic;
using System.Linq;

namespace MissingNumbers.BR
{
    public class MissingNumbersBR
    {
        public string Run()
        {
            try
            {
                InputValidation.PrintInitialMessage();
                int n = Convert.ToInt32(Console.ReadLine());
                InputValidation.ValidateN(n);
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                int m = Convert.ToInt32(Console.ReadLine());
                InputValidation.ValidateN(m);
                int[] brr = Array.ConvertAll(Console.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp));

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

            //foreach (var brrItem in brrList)
            //{
            foreach (var arrItem in arrList)
            {
                if (brrList.Contains(arrItem))
                {
                }
            }
            //    }
            //}
            return string.Empty;
        }
    }
}