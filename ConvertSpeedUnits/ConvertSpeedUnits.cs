namespace ConvertSpeedUnits
{
    internal class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            var distanceMeters = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());

            var totalSeconds = seconds + minutes *60 + (hours * 60 *60);
            var metersPerSec =distanceMeters/ totalSeconds;
            var kilometersPerHour = (distanceMeters / 1000)/(totalSeconds/60/60);
            var milesPerHour = (distanceMeters / 1609f) / (totalSeconds / 60 / 60);

            Console.WriteLine(metersPerSec);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}