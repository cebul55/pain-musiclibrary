﻿using System;
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
    public partial class MusicLibraryMDIContainer : Form
    {
        public MusicLibraryMDIContainer()
        {
            InitializeComponent();
        }

        private void MusicLibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void MusicLibraryFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusicLibraryForm musicLibraryForm = new MusicLibraryForm();
            musicLibraryForm.MdiParent = this;
            musicLibraryForm.Show();
        }

        private void MDIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
