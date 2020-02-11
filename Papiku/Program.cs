using static System.Console;

namespace Papiku
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            Menu d = new DailyMenu();
            Menu w = new WeeklyMenu();
            Write (MealValidator.IsOk(d));
            Write(MealValidator.IsOk(w));
        }
    }
}
