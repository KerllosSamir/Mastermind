using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class CodeGenerator
    {
        protected internal static int[]  Generate()
        {
            Random random = new Random();
            int[] code=new int[4];

            for (int i=0;i<4;i++)
            {
                code[i]= random.Next(1, 6);
            }

            return code;
        }
    }
}
