using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pik_biblioteka_muzyczna {
    public class MusicLibraryDocument {

        public List<Song> songs = new List<Song>();

        public event Action<Song> AddSongEvent;
        public event Action<Song> UpdateSongEvent;
        public event Action<Song> DeleteSongEvent;

        public void AddSong(Song song) {
            songs.Add(song);
            AddSongEvent?.Invoke(song);
        }

        public void UpdateSong(Song oldSong, Song song) {
           // Song publishSong;
            foreach(Song s in songs) {
                if (ReferenceEquals(s, oldSong)) {
             //       publishSong = s;
                    s.Title = song.Title;
                    s.Author = song.Author;
                    s.RecordDate = song.RecordDate;
                    s.Category = song.Category;
                    UpdateSongEvent?.Invoke(s);
                    Console.WriteLine("asdada");
                    return;
                }
            }
        }

        public void DeleteSong(Song song) {
            foreach(Song s in songs) {
                if(ReferenceEquals(s, song)) {
                    DeleteSongEvent?.Invoke(s);
                    songs.Remove(s);
                    return;
                }
            }
        }
    }
}
