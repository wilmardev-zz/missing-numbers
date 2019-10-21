using MissingNumbers.BR;
using System;

namespace MissingNumbers.Init
{
    public static class Init
    {
        public static string InitProgram()
        {
            MissingNumbersBR missingNumbersBR = new MissingNumbersBR();
            return missingNumbersBR.Run();
            //TextWriter textWriter = new StreamWriter(@"C:/", true);

        }
    }
}