using System.Xml.Serialization;

namespace ValueReferanceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Write some string value: ");
            //GetConsoleValue(Console.ReadLine());
            Console.WriteLine("<===============>");

            //Console.Write("Enter the first number: ");
            //string num1 = Console.ReadLine();
            //Console.Write("Enter the second number: ");
            //string num2 = Console.ReadLine();

            //SumOfNums(num1, num2);
            Console.WriteLine("<===============>");

            //int[] numArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int numValAdd = 10;

            //AddElementToArr(ref numArr, numValAdd);

            //foreach (int i in numArr)
            //{
            //    Console.WriteLine(numArr[i]);
            //}

            Console.WriteLine("<===============>");


        }
        //Methodlariniz olur(3 dene). Consoledan deyer goturen method,
        //deyerin int olub olmadigini yoxlayan method, ve cemleyen method(eger her 2si de int ededdirse)
        #region ThreeMethod
        static void GetConsoleValue(string consoleStr)
        {
            Console.WriteLine($"Console Output: {consoleStr}");

            IntOrNot(consoleStr);
        }
        static void IntOrNot(string consoleVal)
        {
            if (int.TryParse(consoleVal, out int result))
            {
                Console.WriteLine("The input is an integer: " + result);
            }
            else
            {
                Console.WriteLine("The input is not an integer.");
            }

        }
        static void SumOfNums(string num1, string num2)
        {
            if (int.TryParse(num1, out int result1) && int.TryParse(num2, out int result2))
            {
                Console.WriteLine($"sum of the Numbers: {result2 + result1}");
            }
            else
            {
                Console.WriteLine("The input is not an integer.");
            }
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