using System;

namespace String_Kata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //To run the tests Click Test on the Menu Bar (Between Team and Analyze)

            //string numbers = "1,2,4,5,6,7,43,5,3,3,3";
            ////string numbers = "1\n2,y,x,4,5,6,10";
            //Console.WriteLine("The sum is: " + Add(numbers));
        }

        public static int Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
                return 0;
            else
            {
                var sum = 0;
                string[] delimiters = {"\n", ",", ";", "//"};
                string[] stringNumbers = numbers.Split(delimiters,StringSplitOptions.RemoveEmptyEntries);
                foreach (var number in stringNumbers)
                {
                    bool isNumeric = Int32.TryParse(number, out int intNumber);
                    if (isNumeric)
                        sum += intNumber;
                    else
                        Console.WriteLine(String.Format("{0} is not a number"));
                }
                return sum;
            }
        }
    }
}
