using System.Runtime.ConstrainedExecution;

namespace konsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = $"../../../Data.txt";

            ShowData(GetData(path));

        }

        /**********************************************
        nazwa funkcji: GetData
        opis funkcji: Pobieranie danych z pliku tekstowego
        parametry: path - ścieżka pliku tekstowego
        
        zwracany typ i opis: List<Song> - zwracana jest lista zawierająca dane z odczytanego pliku tekstowego
        autor: 00000000000
        ***********************************************/

        public static List<Song> GetData(string path)
        {
            List<Song> list = new List<Song>();

            using(StreamReader sr = new StreamReader(path))
            {
                while(!sr.EndOfStream)
                {
                    Song s = new Song();
                    s.Artist = sr.ReadLine() ?? "";
                    s.Album = sr.ReadLine() ?? "";
                    s.SongsNumber = int.Parse(sr.ReadLine() ?? "");
                    s.Year = int.Parse(sr.ReadLine() ?? "");
                    s.DownloadNumber = uint.Parse(sr.ReadLine() ?? "");
                    sr.ReadLine();
                    list.Add(s);
                }
            }
            
            return list;
        }

        public static void ShowData(List<Song> list)
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
