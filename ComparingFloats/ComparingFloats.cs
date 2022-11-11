namespace DataTypesAndVariables
{
    internal class ComparingFloats
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var difference = Math.Abs(a - b);
            const double precision = 0.0000001;
            if(difference < precision)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}