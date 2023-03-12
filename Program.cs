namespace DateTimeAndMathMethods;
class Program
{
    static void Main(string[] args)
    {
        //DateTime
        Console.WriteLine(DateTime.Now);   // 12/03/2023 22:26:49
        Console.WriteLine(DateTime.Now.Date);   // 12/03/2023
        Console.WriteLine(DateTime.Now.Day);   // 12
        Console.WriteLine(DateTime.Now.Month);   // 3
        Console.WriteLine(DateTime.Now.Year);   // 2023
        Console.WriteLine(DateTime.Now.Hour);   // 22
        Console.WriteLine(DateTime.Now.Minute);   // 26
        Console.WriteLine(DateTime.Now.Second);   // 48

        Console.WriteLine(DateTime.Now.DayOfWeek);   // Sunday
        Console.WriteLine(DateTime.Now.DayOfYear);   // 71

        Console.WriteLine(DateTime.Now.ToLongDateString());   // Sunday, 12 March 2023
        Console.WriteLine(DateTime.Now.ToShortDateString());   // 12/03/2023
        Console.WriteLine(DateTime.Now.ToLongTimeString());   // 22:26:49
        Console.WriteLine(DateTime.Now.ToShortTimeString());   // 22:26

        Console.WriteLine(DateTime.Now.AddDays(2));   // 14/03/2023 22:26:49
        Console.WriteLine(DateTime.Now.AddHours(1));   // 12/03/2023 23:26:49
        Console.WriteLine(DateTime.Now.AddSeconds(50));   // 12/03/2023 22:27:39
        Console.WriteLine(DateTime.Now.AddMonths(5));   // 12/08/2023 22:26:49
        Console.WriteLine(DateTime.Now.AddYears(8));   // 12/03/2031 22:26:49
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));   // 12/03/2023 22:26:49

        Console.WriteLine(DateTime.Now.ToString("dd"));   // 12
        Console.WriteLine(DateTime.Now.ToString("ddd"));   // Sun
        Console.WriteLine(DateTime.Now.ToString("dddd"));   // Sunday

        Console.WriteLine(DateTime.Now.ToString("MM"));   // 03
        Console.WriteLine(DateTime.Now.ToString("MMM"));   // Mar
        Console.WriteLine(DateTime.Now.ToString("MMMM"));   // March

        Console.WriteLine(DateTime.Now.ToString("yy"));   // 23
        Console.WriteLine(DateTime.Now.ToString("yyyy"));   //2023


        // Math
        Console.WriteLine(Math.Abs(-54));   // 54
        Console.WriteLine(Math.Sin(30));   // -0.9880316240928618
        Console.WriteLine(Math.Cos(30));   // 0.15425144988758405
        Console.WriteLine(Math.Tan(30));   // -6.405331196646276

        Console.WriteLine(Math.Ceiling(23.3));   // 24
        Console.WriteLine(Math.Round(23.3));   // 23
        Console.WriteLine(Math.Round(23.7));   // 24
        Console.WriteLine(Math.Floor(23.7));   // 23

        Console.WriteLine(Math.Max(3,9));   // 9
        Console.WriteLine(Math.Min(3,9));   // 3

        Console.WriteLine(Math.Pow(3,4));   // 81
        Console.WriteLine(Math.Sqrt(9));   // 3
        Console.WriteLine(Math.Log(9));   // 2.1972245773362196 
        Console.WriteLine(Math.Exp(3));   // 20.085536923187668
        Console.WriteLine(Math.Log10(10));   //1

        
    }
}
