using System;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long countPictures = long.Parse(Console.ReadLine());
            long filterTimeForOnePicture = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long filterPicture =(long)Math.Ceiling(countPictures * (filterFactor / 100.0));
            long firstAnswer = countPictures * filterTimeForOnePicture;
            long secondAnswer = filterPicture * uploadTime;
            long answer = firstAnswer + secondAnswer;

            TimeSpan time = TimeSpan.FromSeconds(answer);
            string str = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);
        }
    }
}
