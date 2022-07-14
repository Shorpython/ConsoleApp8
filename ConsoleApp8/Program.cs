namespace ConsoleApp8
{
    class Homework
    // три метода, первый паблик, потому что только его вызываем в мейне, остальные два-статик, потому что вызываются только внутри класса.
    // надеюсь я правильно понял
    {
        public int Out_Up(int digit)
        {
            string digitString = digit.ToString();
            char[] arr;
            

            arr = digitString.ToCharArray();

            digitString = toIntToString(arr);

            return Convert.ToInt32(digitString);
        }

        static string toIntToString(char[] arr)
        {
            string result = "";
            int[] buf_int = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                buf_int[i] = Convert.ToInt32(arr[i]);
            }
            buf_int = toSortIntArray(buf_int);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char) buf_int[i];
            }

            result = string.Join("", arr);

            return result;

        }
        static int[] toSortIntArray(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        // объявили экземпляр класса, для использования его методов
        Homework myClass = new() { };

        Console.WriteLine("Введите свое число: ");

        int UserInDigit = int.Parse(Console.ReadLine());
        // используем метод того самого класса
        int digitOut = myClass.Out_Up(UserInDigit);

        Console.WriteLine("bah");

        Console.WriteLine(UserInDigit + " to "+ digitOut);

        Console.ReadKey();

        }
}
}