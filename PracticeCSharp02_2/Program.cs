namespace SalesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Environment.CurrentDirectory
            var sales = new SalesCounter("C:/visualstudio/PracticeCSharp/PracticeCSharp02_2/files/sales.csv");
            var amountPerStore = sales.GetPerStoreSales();

            foreach (var pair in amountPerStore)
            {
                Console.WriteLine("{0} {1}", pair.Key, pair.Value);
            }
        }

    }
}