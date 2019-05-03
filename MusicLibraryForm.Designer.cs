namespace pik_biblioteka_muzyczna
{
    partial class MusicLibraryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MusicLibraryListView = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRecordDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripMusicLibraryForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFiltersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMusicLibraryForm = new System.Windows.Forms.ToolStripStatusLabel();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripMusicLibraryForm.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MusicLibraryListView
            // 
            this.MusicLibraryListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.MusicLibraryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderAuthor,
            this.columnHeaderRecordDate,
            this.columnHeaderCategory});
            this.MusicLibraryListView.ContextMenuStrip = this.contextMenuStripMusicLibraryForm;
            this.MusicLibraryListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MusicLibraryListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MusicLibraryListView.FullRowSelect = true;
            this.MusicLibraryListView.GridLines = true;
            this.MusicLibraryListView.Location = new System.Drawing.Point(0, 24);
            this.MusicLibraryListView.MultiSelect = false;
            this.MusicLibraryListView.Name = "MusicLibraryListView";
            this.MusicLibraryListView.ShowItemToolTips = true;
            this.MusicLibraryListView.Size = new System.Drawing.Size(800, 402);
            this.MusicLibraryListView.TabIndex = 0;
            this.MusicLibraryListView.UseCompatibleStateImageBehavior = false;
            this.MusicLibraryListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Author";
            // 
            // columnHeaderRecordDate
            // 
            this.columnHeaderRecordDate.Text = "Record Date";
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Category";
            // 
            // contextMenuStripMusicLibraryForm
            // 
            this.contextMenuStripMusicLibraryForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.clearFiltersToolStripMenuItem1,
            this.toolStripSeparator1,
            this.addToolStripMenuItem1,
            this.updateToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStripMusicLibraryForm.Name = "contextMenuStripMusicLibraryForm";
            this.contextMenuStripMusicLibraryForm.Size = new System.Drawing.Size(136, 120);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.FilterToolStripMenuItem_Click);
            // 
            // clearFiltersToolStripMenuItem1
            // 
            this.clearFiltersToolStripMenuItem1.Name = "clearFiltersToolStripMenuItem1";
            this.clearFiltersToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.clearFiltersToolStripMenuItem1.Text = "Clear Filters";
            this.clearFiltersToolStripMenuItem1.Click += new System.EventHandler(this.ClearFiltersToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.filterToolStripMenuItem1,
            this.clearFiltersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem1
            // 
            this.filterToolStripMenuItem1.Name = "filterToolStripMenuItem1";
            this.filterToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem1.Text = "Filter";
            this.filterToolStripMenuItem1.Click += new System.EventHandler(this.FilterToolStripMenuItem_Click);
            // 
            // clearFiltersToolStripMenuItem
            // 
            this.clearFiltersToolStripMenuItem.Name = "clearFiltersToolStripMenuItem";
            this.clearFiltersToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.clearFiltersToolStripMenuItem.Text = "Clear Filters";
            this.clearFiltersToolStripMenuItem.Click += new System.EventHandler(this.ClearFiltersToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMusicLibraryForm,
            this.FilterStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMusicLibraryForm
            // 
            this.toolStripStatusLabelMusicLibraryForm.Name = "toolStripStatusLabelMusicLibraryForm";
            this.toolStripStatusLabelMusicLibraryForm.Size = new System.Drawing.Size(70, 19);
            this.toolStripStatusLabelMusicLibraryForm.Text = "Status Label";
            this.toolStripStatusLabelMusicLibraryForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FilterStatusLabel
            // 
            this.FilterStatusLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FilterStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.FilterStatusLabel.Name = "FilterStatusLabel";
            this.FilterStatusLabel.Size = new System.Drawing.Size(68, 19);
            this.FilterStatusLabel.Text = "Filter Label";
            this.FilterStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MusicLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MusicLibraryListView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MusicLibraryForm";
            this.Text = "MusicLibraryForm";
            this.Load += new System.EventHandler(this.MusicLibraryForm_Load);
            this.contextMenuStripMusicLibraryForm.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MusicLibraryListView;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
        private System.Windows.Forms.ColumnHeader columnHeaderRecordDate;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMusicLibraryForm;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMusicLibraryForm;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearFiltersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel FilterStatusLabel;
    }
}