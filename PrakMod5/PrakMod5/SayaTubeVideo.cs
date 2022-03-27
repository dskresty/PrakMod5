using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakMod5
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {

            Debug.Assert(title.Length <= 200, "Panjang maksimal judul 200 karakter!");
            Debug.Assert(title != null, "Judul tidak boleh NULL!");

            this.title = title;
            Random random = new Random();
            this.id = random.Next(0, 100000);
            playCount = 0;
        }

        public void IncreasePlayCount(int a)
        {
            Debug.Assert(a <= 25000000, "Maksimal 25.000.000!");
            Debug.Assert(a > 0, "Angka harus positif!");

            int q;
            try
            {
                q = checked(this.playCount + a);
                this.playCount = this.playCount + a;
            }
            catch (OverflowException p)
            {
                Console.WriteLine("\nTerjadi error Overflow: " + p.Message);
                Console.WriteLine("playCount akan ditambah 1");
                this.playCount++;
            }

            playCount = playCount + a;
        }

        public void PrintVideoDetails()
        {
            //Console.WriteLine(title.Length);
            //Console.WriteLine("vidID \t\t: " + id);
            //Console.WriteLine("vidTitle \t: " + title);
            Console.WriteLine("vidPlayCount \t: " + playCount);
            Console.WriteLine("\n");
        }

        public int getPlayCount()
        {
            return playCount;
        }

        public string getTitle()
        {
            return this.title;
        }

    }
}
