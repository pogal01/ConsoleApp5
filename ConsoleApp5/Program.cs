namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1, input2;
            
            Console.WriteLine("input number");
            input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input second number");
            input2 = Convert.ToInt32(Console.ReadLine());

            // Chreck for inputs being equal
            if (input1 == input2)
            {
                Console.WriteLine(input1 + " and "+ input2 +" are equal");
            } else
            {
                Console.WriteLine(input1 + " and " + input2 + " are not equal");
            }


        }
    }
}
