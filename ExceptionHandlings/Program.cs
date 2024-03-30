namespace ExceptionHandlings
{
    class Program
    {
        static void Main(string[] args)
        {
           Types t = new Types();
            //t.Div();
            //t.Exceptions();
            //t.Negative();
            //t.Arguments();
            //t.Integer();
            //t.Format();
            t.Index();
            /*int[] numbers = { 1, 2, 3, 4, 5 };
            double average = t.CalculateAverage(numbers);
            Console.WriteLine("Average: " + average);

            int[] emptyArray = { };
            try
            {
                double emptyArrayAverage = t.CalculateAverage(emptyArray);
                Console.WriteLine("Average: " + emptyArrayAverage);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }*/

        }
    }
}
