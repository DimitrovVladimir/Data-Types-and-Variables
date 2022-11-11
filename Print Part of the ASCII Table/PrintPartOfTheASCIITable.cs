namespace DifferentIntegersSize
{
    internal class PrintPartOfTheASCIITable
    {
        static void Main(string[] args)
        {
            var startIndex = int.Parse(Console.ReadLine());
            var endIndex = int.Parse(Console.ReadLine());
            for (char @char = (char)startIndex; @char <= endIndex; @char++)
            {
                Console.Write(@char + " ");
            }
            
        }
    }
}