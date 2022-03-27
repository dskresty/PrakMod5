using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakMod5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user1 = new SayaTubeUser("Resty");
            //SayaTubeUser user2 = new SayaTubeUser("INI UNTUK USERNAME YANG LEBIH DARI 100 KARAKTER" +
            //    "INI UNTUK USERNAME YANG LEBIH DARI 100 KARAKTER" +
            //    "INI UNTUK USERNAME YANG LEBIH DARI 100 KARAKTER" +
            //    "INI UNTUK USERNAME YANG LEBIH DARI 100 KARAKTER");

            SayaTubeVideo vid1 = new SayaTubeVideo("Review Barbie oleh Resty");
            user1.AddVideo(vid1);

            SayaTubeVideo vid2 = new SayaTubeVideo("Review Film Ambulance oleh Resty");
            user1.AddVideo(vid2);

            SayaTubeVideo vid3 = new SayaTubeVideo("Review Film Piu Piu oleh Resty");
            user1.AddVideo(vid3);

            SayaTubeVideo vid4 = new SayaTubeVideo("Review Film Askja oleh Resty");
            user1.AddVideo(vid4);

            SayaTubeVideo vid5 = new SayaTubeVideo("Review Film Lion oleh Resty");
            user1.AddVideo(vid5);

            SayaTubeVideo vid6 = new SayaTubeVideo("Review Film Gajah oleh Resty");
            user1.AddVideo(vid6);

            SayaTubeVideo vid7 = new SayaTubeVideo("Review Film ABC oleh Resty");

            string utkNULL = null;
            SayaTubeVideo vid0 = new SayaTubeVideo("Review Film ISAJFIAJF oleh Resty");
            user1.AddVideo(vid7);

            SayaTubeVideo vid8 = new SayaTubeVideo("Review Film Apa Aja oleh Resty");
            vid8.IncreasePlayCount(25000001);
            user1.AddVideo(vid8);

            SayaTubeVideo vid9 = new SayaTubeVideo("Review Film asfaf oleh Resty");
            vid8.IncreasePlayCount(-1);
            user1.AddVideo(vid9);

            SayaTubeVideo vid10 = new SayaTubeVideo("Review Film Ya oleh Resty");
            user1.AddVideo(vid10);
            //user1.AddVideo(null);

            vid10.IncreasePlayCount(24000000);
            //vid10.IncreasePlayCount(900000000);
            //vid10.IncreasePlayCount(900000000);
            //vid10.IncreasePlayCount(900000000);
            //vid10.IncreasePlayCount(900000000);

            user1.GetTotalVideoPlayCount();

            user1.PrintAllVideoPlaycount();
            Console.WriteLine("\n");
        }



    }
    
}
