namespace Centuries_to_Nanoseconds
{
    internal class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            var centuries = decimal.Parse(Console.ReadLine());

            var years = centuries * 100;
            var days = Math.Floor(years * 365.2422m);
            var hours = days * 24;
            var minutes = hours * 60;
            var seconds = minutes * 60;
            var milliseconds = seconds * 1000;
            var microseconds = milliseconds * 1000;
            var nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}