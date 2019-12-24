using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Utility
    {
        protected internal static bool CheckMasterCode(int[] masterCode, int[] userCode, out string result)
        {
            StringBuilder compination = new StringBuilder();
            bool match = true;

            for (int i = 0; i < 4; i++)
            {
                if (masterCode[i] == userCode[i])
                {
                    compination.Append("+");
                }
                else if (masterCode.Contains(userCode[i]))
                {
                    compination.Append("-");
                    match = false;
                }
                else
                {
                    compination.Append(" ");
                    match = false;
                }
            }

            result = compination.ToString();

            return match;
        }

        protected internal static int[] ExtractUserInputDigits(string userInput)
        {
            int[] userCode = new int[4];
            for (int i = 0; i < 4; i++)
            {
                userCode[i] = int.Parse(userInput[i].ToString());
            }
            return userCode;
        }
    }
}
