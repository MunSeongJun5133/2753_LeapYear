namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            System.UInt16 lp = System.UInt16.Parse(Console.ReadLine());
            if (lp % 4 == 0 && (lp % 100 != 0 || lp % 400 == 0))
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}