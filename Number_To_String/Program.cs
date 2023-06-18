using System.Text;

namespace Number_To_String
{
    internal class Program
    {
        public delegate void NumberToStringDelegate();
        public static NumberToStringDelegate numberToStringDelegate = NumberToStringMethod;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            numberToStringDelegate();
        }
        public static void NumberToStringMethod()
        {
            Console.WriteLine("Please Enter 3 Digit Number");
            int number = Convert.ToInt32(Console.ReadLine());
            string loopNumber = Convert.ToString(number);
            string toStringNumber;
            StringBuilder sb = new StringBuilder();
            int numberOnly;
            for (int i = loopNumber.Length - 1; i >= 0; i--)
            {


                if (i == 0)
                {
                    numberOnly = number % 10;
                    string[] unit = { " tl", " one ", " two ", " three ", " four ", " five ", " six ", " seven ", " eigth ", " nine " };
                    toStringNumber = unit[numberOnly];
                    sb.Append(toStringNumber);
                }
                if (i == 1)
                {
                    numberOnly = (number / 10) % 10;
                    string[] unit = { "", " ten", " twenty", " thirty", " fourthy", " fifthy", " sixty", " seventy", " eigthy", " ninety" };
                    toStringNumber = unit[numberOnly];
                    sb.Append(toStringNumber);
                }
                if (i == 2)
                {
                    numberOnly = number / 100;
                    string[] unit = { "", "one hundred", "two hundred", "three hundreed", "four hundred", "five hundred", "six hundred", "seven hundred", "eigth hundred", "nine hundred" };
                    toStringNumber = unit[numberOnly];
                    sb.Append(toStringNumber);
                }


            }
            Console.WriteLine(sb);
            Console.ReadLine(); 
        }
    }
}