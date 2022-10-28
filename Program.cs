using GenericsProblem;
using System.Runtime.Intrinsics.X86;

namespace Generics

{
    class Program

    {
        public static void Main(string[] args)
        {
            //int firstNumber = 100, secondNumber = 150, thirdNumber = 200;
            //int num = MaximumNumber.MaximumIntegerNumber(firstNumber, secondNumber, thirdNumber);
            //Console.WriteLine(num + "is greater among three");                                                          USECASE-1

            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            //double firstNumber = 1.00, secondNumber = 1.50, thirdNumber = 2.00;
            //double num = FloatMaximumNumber.MaximumFloatNumber(firstNumber, secondNumber, thirdNumber);
            //Console.WriteLine(num + "is greater among three");                                                          USECASE-2

            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            //string first  = "Apple";
            //string second = "Banana";
            //string third  = "Peach";
            //string num = StringMaximum.MaximumStringNumber(first, second, third);
            //Console.WriteLine(num + "is greater among three");                                                          USECASE-3

            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            //int first = 100, second = 150, third = 200;
            //int num = Refactor1<int>.MaximumNumber(first, second, third);
            //Console.WriteLine(num + "is greater among three");                                                          REFACTOR

            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            //int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //char[] charArray = { 'S', 'W', 'A', 'T', 'H', 'I' };
            //string[] stringArray = { "swathi", "preetham", "Bhavani", "Buvaneshwari" };

            //PrintArray<int> intobj = new PrintArray<int>(intArray);
            //intobj.toprint();
            //PrintArray<char> intobj = new PrintArray<char>(charArray);
            //intobj.toprint();
            //PrintArray<string> intobj = new PrintArray<string>(stringArray);                                         
            //intobj.toprint();                                                                                           USECASE-4

            Console.WriteLine("---------------------------------------------------------------------------------------------------");
        }
    }
}