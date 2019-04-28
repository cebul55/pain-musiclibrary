using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pik_biblioteka_muzyczna
{
    public partial class MusicLibraryForm : Form {
        private MusicLibraryDocument musicLibraryDocument {
            get;
            set;
        }
        public MusicLibraryForm(MusicLibraryDocument document) {
            InitializeComponent();
            this.musicLibraryDocument = document;
        }
        private void MusicLibraryForm_Load(object sender, EventArgs e) {
            UpdateItems();
            musicLibraryDocument.AddSongEvent += musicLibraryDocument_AddSongEvent;
            musicLibraryDocument.UpdateSongEvent += musicLibraryDocument_UpdateSongEvent;
            musicLibraryDocument.DeleteSongEvent += musicLibraryDocument_DeleteSongEvent;
            setToolStripStatusLabelMusicLibraryForm_Text();

            setUpColumnWidth();
        }

        protected override void OnInvalidated(InvalidateEventArgs e) {
            setUpColumnWidth();
            setToolStripStatusLabelMusicLibraryForm_Text();
        }

        private void setUpColumnWidth() {
            //autosize columns widht
            MusicLibraryListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            MusicLibraryListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void setToolStripStatusLabelMusicLibraryForm_Text() {
            toolStripStatusLabelMusicLibraryForm.Text = ("Number of items: " + MusicLibraryListView.Items.Count + ".");
        }

        private void musicLibraryDocument_AddSongEvent(Song song) {
            ListViewItem item = new ListViewItem();
            item.Tag = song;
            UpdateItem(item);
            MusicLibraryListView.Items.Add(item);
            Invalidate();
            //this.setUpColumnWidth();
        }

            private void musicLibraryDocument_UpdateSongEvent(Song song) {
            UpdateItems();
            Invalidate();
            //this.setUpColumnWidth();
        }

        private void musicLibraryDocument_DeleteSongEvent(Song song) {
            foreach(ListViewItem item in MusicLibraryListView.Items) {
                if(ReferenceEquals((Song) item.Tag, song)) {
                    MusicLibraryListView.Items.Remove(item);
                    return;
                }
            }
        }

        private void UpdateItems() {
            MusicLibraryListView.Items.Clear();
            foreach (Song s in musicLibraryDocument.songs) {
                ListViewItem item = new ListViewItem();
                item.Tag = s;
                UpdateItem(item);
                MusicLibraryListView.Items.Add(item);
            }
        }

        private void UpdateItem(ListViewItem item) {
            Song song = (Song)item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = song.Title;
            item.SubItems[1].Text = song.Author;
            item.SubItems[2].Text = song.RecordDate.ToShortDateString();
            item.SubItems[3].Text = song.Category;
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e) {
            SongForm songForm = new SongForm(null, musicLibraryDocument.songs);
            if (songForm.ShowDialog() == DialogResult.OK) {
                Song newSong = new Song(songForm.SongTitle, songForm.SongAuthor, songForm.SongDateRecorded, songForm.SongCategory);
                musicLibraryDocument.AddSong(newSong);
            }
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MusicLibraryListView.SelectedItems.Count == 1) {
                Song song = (Song)MusicLibraryListView.SelectedItems[0].Tag;
                Song oldSong = (Song)MusicLibraryListView.SelectedItems[0].Tag;
                SongForm form = new SongForm(song, musicLibraryDocument.songs);
                if (form.ShowDialog() == DialogResult.OK) {
                    song.Title = form.SongTitle;
                    song.Author = form.SongAuthor;
                    song.RecordDate = form.SongDateRecorded;
                    song.Category = form.SongCategory;

                    musicLibraryDocument.UpdateSong(oldSong, song);
                }
            }
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e) {
            if(MusicLibraryListView.SelectedItems.Count == 1) {
                Song song = (Song)MusicLibraryListView.SelectedItems[0].Tag;
                musicLibraryDocument.DeleteSong(song);
                setToolStripStatusLabelMusicLibraryForm_Text();
            }
        }

        private void FilterToolStripMenuItem_Click(object sender, EventArgs e) {
            FilterForm filterForm = new FilterForm();
            if(filterForm.ShowDialog() == DialogResult.OK) {
                DateTime minDate = filterForm.MinDateValue;
                DateTime maxDate = filterForm.MaxDateValue;
                DateFilterItems(minDate, maxDate);
                Invalidate();
            }
        }
        private void ClearFiltersToolStripMenuItem_Click(object sender, EventArgs e) {
            UpdateItems();
            Invalidate();
        }
        private void DateFilterItems(DateTime minDate, DateTime maxDate) {
            MusicLibraryListView.Items.Clear();
            foreach (Song s in musicLibraryDocument.songs) {
                Console.WriteLine(minDate + " " + maxDate + " " + s.RecordDate);
                if (s.RecordDate >= minDate && s.RecordDate <= maxDate) {
                    ListViewItem item = new ListViewItem();
                    item.Tag = s;
                    UpdateItem(item);
                    MusicLibraryListView.Items.Add(item);
                }
            }
        }



    }
}
