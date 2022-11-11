namespace TheaThePhotographer
{
    internal class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            var picturesCount = int.Parse(Console.ReadLine());
            var singlePictureFilterTimeSecond = int.Parse(Console.ReadLine());
            var filterPersentige = int.Parse(Console.ReadLine());
            var singlePictureUploadTimeSeconds = int.Parse(Console.ReadLine());

            var filterTimeSeconds = (long)singlePictureFilterTimeSecond * picturesCount;
            var pictureToUploadCount = (long)Math.Ceiling(picturesCount * (filterPersentige/100d));
            var uploadTimeSeconds = pictureToUploadCount*singlePictureUploadTimeSeconds;

            var totalTimeNeededSeconds = filterTimeSeconds + uploadTimeSeconds;

            var totalTimeNeededTimeSpan = TimeSpan.FromSeconds(totalTimeNeededSeconds);

            Console.WriteLine(totalTimeNeededTimeSpan.ToString(@"dd\:hh\:mm\:ss"));

        }
    }
}