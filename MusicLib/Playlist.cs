using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLib
{
    class Playlist
    {
        public string PlayListName { get; set; }
        public int NoOfSongs { get; set; }
        public List<string> songs { get; set; }

        public static Playlist GetPlaylist()
        {
            //creating a dummy playlist
            //initializing Playlistname immediately after creating dummy playlist
            var plalylist = new Playlist
            {
                PlayListName = "Workout Songs",
                NoOfSongs = 4,
                songs = new List<string> () { "abc", "def", "ghi"}
            };
            return plalylist;
        }
        //writing the playlist to a flat file using this Function 
        //this function takes UserPlaylistsPage object as input
        public static void WritePlaylistNameNCount(Playlist playlist)
        {
            var playlistdata = $"{playlist.PlayListName}+\t+{playlist.NoOfSongs}";
            FileHelper.WriteTextFileAsyc("playlistNameNCount.txt", playlistdata);
        }
    }
}

