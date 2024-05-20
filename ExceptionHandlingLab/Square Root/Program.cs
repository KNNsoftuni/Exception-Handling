namespace Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = int.Parse(Console.ReadLine());

                if (input < 0)
                {
                    throw new Exception($"Invalid Number");
                }

                Console.WriteLine(Math.Sqrt(input));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}