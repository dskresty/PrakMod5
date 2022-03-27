using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakMod5
{
    internal class SayaTubeUser
    {
        private int id;
        public string Username;
        List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string name)
        {
            Debug.Assert(name.Length <= 100, "Panjang username maks 100 char!");
            Debug.Assert(name != null, "Username tidak boleh null");
            this.Username = name;

            Random random = new Random();
            this.id = random.Next(0, 100000);
            uploadedVideos = new List<SayaTubeVideo>();
            this.Username = name;

        }

        public int GetTotalVideoPlayCount()
        {
            int b, c;
            b = 0;

            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                c = uploadedVideos[i].getPlayCount();
                b = b + c;
            }

            return b;
        }

        public void AddVideo(SayaTubeVideo x)
        {
            Debug.Assert(x != null, "Video yang ditambahkan tidak berupa null!");
            Debug.Assert(x.getPlayCount() < int.MaxValue, "playCount harus kurang dari int max!");
            uploadedVideos.Add(x);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User \t: " + this.Username);
            Console.WriteLine("\n");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul \t: " + uploadedVideos[i].getTitle());
                uploadedVideos[i].PrintVideoDetails();
            }

        }
    }
}
