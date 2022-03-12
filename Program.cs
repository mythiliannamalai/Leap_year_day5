class Leap
{
    public void Calculation()
    {
        Console.WriteLine("enter the year");
        int year = int.Parse(Console.ReadLine());
        if (((year % 4 == 0) && (year % 100 == 0)) || (year % 400 == 0))
        {
            Console.WriteLine("{0} is a leap year", year); 
        }
        else
        {
            Console.WriteLine("{0} is not leap year", year);
        }
    }
}
class Result
{
    public static void Main(string[] args)
    {
        Leap leap = new Leap();
        leap.Calculation();
    }
}