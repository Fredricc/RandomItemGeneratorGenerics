namespace RandomItemGeneratorGenerics
{

    public class RandomItemGenerator<T>
    {
        private readonly List<T> _items = new List<T>();
        private readonly Random _random = new Random();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T Get()
        {
            var index = _random.Next(0, _items.Count);
            return _items[index];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new RandomItemGenerator<string>();
            cities.Add("Mombasa");
            cities.Add("Nakuru");
            cities.Add("Eldoret");
            cities.Add("Nairobi");

            for (int i = 0; i < 10; i++)
            {
                var randomCity = cities.Get();
                Console.WriteLine(randomCity);
            }

            Console.WriteLine();

            var numbers = new RandomItemGenerator<int>();
            numbers.Add(4);
            numbers.Add(9);
            numbers.Add(89);
            numbers.Add(45);

            for (int i = 0; i < 10; i++)
            {
                var randomNum = numbers.Get();
                Console.WriteLine(randomNum);
            }
        }
    }
}