using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Torrent_Pirate
{
    class TorrentPirate
    {
        static void Main()
        {

            Console.WriteLine("download MBs");
            double d = double.Parse(Console.ReadLine()); //kolko mb 6te tegli
            Console.WriteLine("cinema price");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("wife spending");
            double w = double.Parse(Console.ReadLine());

            double downloadTime = d / 2 / 60 / 60;  // za kolko 4asa 6te gi iztegli
            double priceForDownaload = downloadTime * w; //cenata da gi iztegli + razhodite na jena mu 
            Console.WriteLine(priceForDownaload);
            Console.WriteLine(downloadTime);
            double numberOfMoviesDownloaded = d / 1500;
            double cinemaPrice = numberOfMoviesDownloaded * p; //kolko 6te mu struva da izgleda filmite (20*5 = 100lv)
           
            if (priceForDownaload > cinemaPrice)
            Console.WriteLine("cinema -> {0:f2}lv", cinemaPrice);
            else
            {
                Console.WriteLine("mall -> {0:f2}lv", priceForDownaload);
            }
        }
    }
}
