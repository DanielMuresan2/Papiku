namespace Papiku.BusinessLogic
{
    internal class Food
    {
        public string name { get; }
        public decimal calories { get; }
        public short? quantity;

        public Food(string _name, decimal _calories)
        {
            name = _name;
            calories = _calories;
        }

        public Food(string _name, decimal _calories, short _quantity)
        {
            name = _name;
            calories = _calories;
            quantity = _quantity;
        }
    }
}