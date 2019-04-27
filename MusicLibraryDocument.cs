using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pik_biblioteka_muzyczna {
    class MusicLibraryDocument {

        public List<Song> songs = new List<Song>();

        public event Action<Song> AddSongEvent;

        public void AddSong(Song song) {
            songs.Add(song);
            AddSongEvent?.Invoke(song);
        }

        public void UpdateSong(Song song) {
            //todo implement updating
            throw new NotImplementedException();
        }

        public void DeleteSong(Song song) {
            //todo implement deleting
            throw new NotImplementedException();
        }
    }
}
