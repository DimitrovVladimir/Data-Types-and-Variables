namespace IntegerToHexAndBinary
{
    internal class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
          var num = int.Parse(Console.ReadLine());


            var hexadecimal = Convert.ToString(num, 16).ToUpper();
            var binary = Convert.ToString(num, 2);

            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);
        }
    }
}