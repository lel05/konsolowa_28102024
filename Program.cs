namespace konsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = $"../../../Data.txt";

            ShowData(GetData(path));
            
        }

        static List<Song> GetData(string path)
        {
            List<Song> list = new List<Song>();

            using(StreamReader sr = new StreamReader(path))
            {
                while(!sr.EndOfStream)
                {
                    Song s = new Song();
                    s.Artist = sr.ReadLine();
                    s.Album = sr.ReadLine();
                    s.SongsNumber = int.Parse(sr.ReadLine());
                    s.Year = int.Parse(sr.ReadLine());
                    s.DownloadNumber = uint.Parse(sr.ReadLine());
                    sr.ReadLine();
                    list.Add(s);
                }
            }
            
            return list;
        }

        static void ShowData(List<Song> list)
        {
            foreach(Song s in list)
            {
                Console.WriteLine(s.Artist);
                Console.WriteLine(s.Album);
                Console.WriteLine(s.SongsNumber);
                Console.WriteLine(s.Year);
                Console.WriteLine(s.DownloadNumber);
                Console.WriteLine("");
            }
        }
    }
}
