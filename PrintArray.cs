using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics;

namespace GenericsProblem
{
    public class PrintArray<T>
    {
        private T[] inputArray;

        public PrintArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void toprint()
        {
              foreach (var ele in inputArray)
              {
                Console.WriteLine(ele);
              }
        }
    }
}
