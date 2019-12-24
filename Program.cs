using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] code = CodeGenerator.Generate();
            int attempts = 0;
            while (attempts < 10)
            {
                Console.WriteLine("Please enter 4 digits (1 to 6) code");
                string userCode = Console.ReadLine();
                int intCode = 0;

                if (int.TryParse(userCode, out intCode))
                {

                    if (userCode.Length != 4)
                    {
                        Console.Write("Code length not valid ,");
                    }
                    else
                    {
                        //Console.WriteLine(userCode);
                        string res;
                        int[] userCodeDigits = Utility.ExtractUserInputDigits(userCode);
                        if (Utility.CheckMasterCode(code, userCodeDigits, out res))
                        {
                            Console.WriteLine("Congratulations you won");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sorry you didn't win , kindly try again " + res);
                        }
                    }
                }
                else
                {
                    Console.Write("Invalid number ,");
                }

                attempts++;
            }
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
