using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pik_biblioteka_muzyczna {
    public partial class SongForm : Form {

        private Song song;
        private List<Song> songs;

        public string SongTitle {
            get { return TitleTextBoxSongForm.Text; }
        }

        public string SongAuthor {
            get { return AuthorTextBoxSongForm.Text; }
        }

        public DateTime SongDateRecorded {
            get { return datePickerSongForm.Value; }
        }

        public string SongCategory {
            get { return comboCategorySongForm.Text; }
        }

        public SongForm(Song song, List<Song> songs) {
            InitializeComponent();
            //bind ComboCategorySongForm with CategoryEnum
            comboCategorySongForm.DataSource = Enum.GetNames(typeof(CategoryEnum));
            this.song = song;
            this.songs = songs;
        }

        private void SongForm_Load(object sender, EventArgs e) {
            if(song != null) {
                titleLabelSongForm.Text = song.Title;
                AuthorTextBoxSongForm.Text = song.Author;
                datePickerSongForm.Value = song.RecordDate;
                comboCategorySongForm.Text = song.Category;
            }

        }
        private void AddButtonStudentForm_Click(object sender, EventArgs e) {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }
        private void CancelButtonSongForm_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            //this.Dispose();
        }

        private void TitleLabelSongForm_Click(object sender, EventArgs e) {

        }



        private void ComboCategorySongForm_SelectedIndexChanged(object sender, EventArgs e) {

        }



        private void DatePickerSongForm_ValueChanged(object sender, EventArgs e) {

        }

        private void TitleTextBoxSongForm_TextChanged(object sender, EventArgs e) {

        }


    }
}
