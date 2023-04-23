using System.Text;

Console.WriteLine("Please Enter 3 Digit Number");
int number = Convert.ToInt32(Console.ReadLine());
string loopnumber = Convert.ToString(number);
string tostringnumber;
StringBuilder sb = new StringBuilder();
int numberonly;
for (int i = loopnumber.Length - 1; i >= 0; i--)
{


    if (i == 0)
    {
        numberonly = number % 10;
        string[] unit = { " tl", " one ", " two ", " three ", " four ", " five ", " six ", " seven ", " eigth ", " nine " };
        tostringnumber = unit[numberonly];
        sb.Append(tostringnumber);
    }
    if (i == 1)
    {
        numberonly = (number / 10) % 10;
        string[] unit = { "", " ten", " twenty", " thirty", " fourthy", " fifthy", " sixty", " seventy", " eigthy", " ninety" };
        tostringnumber = unit[numberonly];
        sb.Append(tostringnumber);
    }
    if (i == 2)
    {
        numberonly = number / 100;
        string[] unit = { "", "one hundred", "two hundred", "three hundreed", "four hundred", "five hundred", "six hundred", "seven hundred", "eigth hundred", "nine hundred" };
        tostringnumber = unit[numberonly];
        sb.Append(tostringnumber);
    }


}
Console.WriteLine(sb);
Console.ReadLine();