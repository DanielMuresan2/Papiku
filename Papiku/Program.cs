using static System.Console;

namespace Papiku
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Menu d = new DailyMenu();
            Menu w = new WeeklyMenu();
            //Write (MealValidator.IsOk(d));
            //Write(MealValidator.IsOk(w));
            PapikuEntryPoint papi = new PapikuEntryPoint();
            papi.start();
        }
    }
}
