using System.Xml.Serialization;

namespace ValueReferanceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetConsoleValue();

            int[] numbers = { 1, 2, 3, 4, 5 };
            AddElementToArr(ref numbers, 12);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }



        }
        //Methodlariniz olur(3 dene). Consoledan deyer goturen method,
        //deyerin int olub olmadigini yoxlayan method, ve cemleyen method(eger her 2si de int ededdirse)
        #region ThreeMethod
        static void GetConsoleValue()
        {
            Console.Write("Enter the first input: ");
            string word1 = Console.ReadLine();
            Console.Write("Enter the second input: ");
            string word2 = Console.ReadLine();
            Console.WriteLine($"Console Output: {word1} , {word2}");
            IntOrNot(word1, word2);
        }
        static void IntOrNot(string consoleVal1, string consoleVal2)
        {
            bool val1 = int.TryParse(consoleVal1, out int result1);
            bool val2 = int.TryParse(consoleVal2, out int result2);
            if (val1 && val2)
            {
                Console.WriteLine($"The input {result1} and {result2} is an integer");
            }
            else
            {
                Console.WriteLine("The inputs is not an integer.");
            }
            Console.WriteLine("Sum of numbers:" + SumOfNums(result1, result2));
        }
        static int SumOfNums(int num1, int num2)
        {
            return num1 + num2;
        }
        #endregion
        //Parameter olaraq integer array variable-i (reference) ve bir integer value qebul eden
        //ve hemin integer value-nu integer array-e yeni element kimi elave eden metod.
        #region Add New Element to the Array
        static void AddElementToArr(ref int[] array, int newArrItem)
        {
            int[] newArr = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
            }
            newArr[^1] = newArrItem;
            array = newArr;
        }
        #endregion
    }
}