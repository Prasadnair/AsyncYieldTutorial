using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncYield
{
    internal class AsyncGeneretors
    {

        public static async IAsyncEnumerable<int> GenerateNumbersAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100); // Simulate asynchronous work
                yield return i;
            }
        }

    }
}
