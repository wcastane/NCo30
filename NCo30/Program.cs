using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharpSapRfc;

namespace NCo30
{
    class Program
    {
        static void Main(string[] args)
        {

            using (SapRfcConnection conn = new SapRfcConnection("TST"))
            {
                var result = conn.ExecuteFunction("Z_SSRT_SUM", new
                {
                    i_num1 = 2,
                    i_num2 = 4
                });

                int xresult = result.GetOutput<int>("e_result");
            }
        }
    }
}
