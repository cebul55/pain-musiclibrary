using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                TitleTextBoxSongForm.Text = song.Title;
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
        }

        private void TitleTextBoxSongForm_Validating(object sender, CancelEventArgs e) {
            try {
                string title = (string)TitleTextBoxSongForm.Text;
                string author = (string)AuthorTextBoxSongForm.Text;
                foreach ( Song s in songs) {
                    if (s.Title == title && s.Author == author && !ReferenceEquals(s, song))
                        throw new Exception("Song wiht given Title and Author already exists in library.");
                }
            }
            catch(Exception exception) {
                e.Cancel = true;
                errorProviderTitleSongForm.SetError(TitleTextBoxSongForm, exception.Message);
            }
        }

        private void TitleTextBoxSongForm_Validated (object sender, EventArgs e) {
            errorProviderTitleSongForm.SetError(titleLabelSongForm, "");
        }

        private void datePickerSongForm_Validating(object sender, CancelEventArgs e) {
            try {
                DateTime date = System.DateTime.Now;
                DateTime insertedDate = datePickerSongForm.Value;
                if (insertedDate > date)
                    throw new Exception("Date cannot be grater than today's date.");
            }
            catch(Exception exception) {
                e.Cancel = true;
                errorProviderDateSongForm.SetError(datePickerSongForm, exception.Message);
            }
        }

        private void datePickerSongForm_Validated(object sender, EventArgs e) {
            errorProviderDateSongForm.SetError(datePickerSongForm, "");
        }

        private void ComboCategorySongForm_SelectedIndexChanged(object sender, EventArgs e) {

        }


        private void TitleTextBoxSongForm_TextChanged(object sender, EventArgs e) {

        }


    }
}
