namespace pik_biblioteka_muzyczna {
    partial class SongForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutSongForm = new System.Windows.Forms.TableLayoutPanel();
            this.authorLabelSongForm = new System.Windows.Forms.Label();
            this.RecordDateLabelSongForm = new System.Windows.Forms.Label();
            this.categoryLabelSongForm = new System.Windows.Forms.Label();
            this.titleLabelSongForm = new System.Windows.Forms.Label();
            this.cancelButtonSongForm = new System.Windows.Forms.Button();
            this.datePickerSongForm = new System.Windows.Forms.DateTimePicker();
            this.comboCategorySongForm = new System.Windows.Forms.ComboBox();
            this.AuthorTextBoxSongForm = new System.Windows.Forms.TextBox();
            this.TitleTextBoxSongForm = new System.Windows.Forms.TextBox();
            this.AddButtonStudentForm = new System.Windows.Forms.Button();
            this.tableLayoutSongForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutSongForm
            // 
            this.tableLayoutSongForm.AutoScroll = true;
            this.tableLayoutSongForm.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.tableLayoutSongForm.AutoSize = true;
            this.tableLayoutSongForm.ColumnCount = 2;
            this.tableLayoutSongForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutSongForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutSongForm.Controls.Add(this.authorLabelSongForm, 0, 1);
            this.tableLayoutSongForm.Controls.Add(this.RecordDateLabelSongForm, 0, 2);
            this.tableLayoutSongForm.Controls.Add(this.categoryLabelSongForm, 0, 3);
            this.tableLayoutSongForm.Controls.Add(this.titleLabelSongForm, 0, 0);
            this.tableLayoutSongForm.Controls.Add(this.cancelButtonSongForm, 1, 4);
            this.tableLayoutSongForm.Controls.Add(this.datePickerSongForm, 1, 2);
            this.tableLayoutSongForm.Controls.Add(this.comboCategorySongForm, 1, 3);
            this.tableLayoutSongForm.Controls.Add(this.AuthorTextBoxSongForm, 1, 1);
            this.tableLayoutSongForm.Controls.Add(this.TitleTextBoxSongForm, 1, 0);
            this.tableLayoutSongForm.Controls.Add(this.AddButtonStudentForm, 0, 4);
            this.tableLayoutSongForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutSongForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutSongForm.Name = "tableLayoutSongForm";
            this.tableLayoutSongForm.RowCount = 5;
            this.tableLayoutSongForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutSongForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutSongForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutSongForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutSongForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutSongForm.Size = new System.Drawing.Size(665, 238);
            this.tableLayoutSongForm.TabIndex = 0;
            // 
            // authorLabelSongForm
            // 
            this.authorLabelSongForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLabelSongForm.AutoSize = true;
            this.authorLabelSongForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.authorLabelSongForm.Location = new System.Drawing.Point(3, 47);
            this.authorLabelSongForm.Name = "authorLabelSongForm";
            this.authorLabelSongForm.Size = new System.Drawing.Size(326, 47);
            this.authorLabelSongForm.TabIndex = 3;
            this.authorLabelSongForm.Text = "Author";
            this.authorLabelSongForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecordDateLabelSongForm
            // 
            this.RecordDateLabelSongForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordDateLabelSongForm.AutoSize = true;
            this.RecordDateLabelSongForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RecordDateLabelSongForm.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RecordDateLabelSongForm.Location = new System.Drawing.Point(3, 94);
            this.RecordDateLabelSongForm.Name = "RecordDateLabelSongForm";
            this.RecordDateLabelSongForm.Size = new System.Drawing.Size(326, 47);
            this.RecordDateLabelSongForm.TabIndex = 4;
            this.RecordDateLabelSongForm.Text = "Record Date";
            this.RecordDateLabelSongForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryLabelSongForm
            // 
            this.categoryLabelSongForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryLabelSongForm.AutoSize = true;
            this.categoryLabelSongForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryLabelSongForm.Location = new System.Drawing.Point(3, 141);
            this.categoryLabelSongForm.Name = "categoryLabelSongForm";
            this.categoryLabelSongForm.Size = new System.Drawing.Size(326, 47);
            this.categoryLabelSongForm.TabIndex = 5;
            this.categoryLabelSongForm.Text = "Music Category";
            this.categoryLabelSongForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabelSongForm
            // 
            this.titleLabelSongForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabelSongForm.AutoSize = true;
            this.titleLabelSongForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabelSongForm.Location = new System.Drawing.Point(3, 0);
            this.titleLabelSongForm.Name = "titleLabelSongForm";
            this.titleLabelSongForm.Size = new System.Drawing.Size(326, 47);
            this.titleLabelSongForm.TabIndex = 2;
            this.titleLabelSongForm.Text = "Title";
            this.titleLabelSongForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabelSongForm.Click += new System.EventHandler(this.TitleLabelSongForm_Click);
            // 
            // cancelButtonSongForm
            // 
            this.cancelButtonSongForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButtonSongForm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cancelButtonSongForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButtonSongForm.Location = new System.Drawing.Point(335, 191);
            this.cancelButtonSongForm.Name = "cancelButtonSongForm";
            this.cancelButtonSongForm.Size = new System.Drawing.Size(327, 44);
            this.cancelButtonSongForm.TabIndex = 1;
            this.cancelButtonSongForm.Text = "Cancel";
            this.cancelButtonSongForm.UseVisualStyleBackColor = false;
            this.cancelButtonSongForm.Click += new System.EventHandler(this.CancelButtonSongForm_Click);
            // 
            // datePickerSongForm
            // 
            this.datePickerSongForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.datePickerSongForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePickerSongForm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerSongForm.Location = new System.Drawing.Point(398, 97);
            this.datePickerSongForm.Name = "datePickerSongForm";
            this.datePickerSongForm.Size = new System.Drawing.Size(200, 29);
            this.datePickerSongForm.TabIndex = 6;
            this.datePickerSongForm.Value = new System.DateTime(2019, 4, 27, 23, 29, 53, 0);
            this.datePickerSongForm.ValueChanged += new System.EventHandler(this.DatePickerSongForm_ValueChanged);
            // 
            // comboCategorySongForm
            // 
            this.comboCategorySongForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboCategorySongForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategorySongForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboCategorySongForm.FormattingEnabled = true;
            this.comboCategorySongForm.Location = new System.Drawing.Point(398, 144);
            this.comboCategorySongForm.Name = "comboCategorySongForm";
            this.comboCategorySongForm.Size = new System.Drawing.Size(201, 32);
            this.comboCategorySongForm.TabIndex = 7;
            this.comboCategorySongForm.SelectedIndexChanged += new System.EventHandler(this.ComboCategorySongForm_SelectedIndexChanged);
            // 
            // AuthorTextBoxSongForm
            // 
            this.AuthorTextBoxSongForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AuthorTextBoxSongForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AuthorTextBoxSongForm.Location = new System.Drawing.Point(398, 50);
            this.AuthorTextBoxSongForm.Name = "AuthorTextBoxSongForm";
            this.AuthorTextBoxSongForm.Size = new System.Drawing.Size(200, 29);
            this.AuthorTextBoxSongForm.TabIndex = 8;
            // 
            // TitleTextBoxSongForm
            // 
            this.TitleTextBoxSongForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TitleTextBoxSongForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleTextBoxSongForm.Location = new System.Drawing.Point(398, 3);
            this.TitleTextBoxSongForm.Name = "TitleTextBoxSongForm";
            this.TitleTextBoxSongForm.Size = new System.Drawing.Size(200, 29);
            this.TitleTextBoxSongForm.TabIndex = 9;
            this.TitleTextBoxSongForm.TextChanged += new System.EventHandler(this.TitleTextBoxSongForm_TextChanged);
            // 
            // AddButtonStudentForm
            // 
            this.AddButtonStudentForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButtonStudentForm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddButtonStudentForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddButtonStudentForm.Location = new System.Drawing.Point(3, 191);
            this.AddButtonStudentForm.Name = "AddButtonStudentForm";
            this.AddButtonStudentForm.Size = new System.Drawing.Size(326, 44);
            this.AddButtonStudentForm.TabIndex = 10;
            this.AddButtonStudentForm.Text = "Add";
            this.AddButtonStudentForm.UseVisualStyleBackColor = false;
            this.AddButtonStudentForm.Click += new System.EventHandler(this.AddButtonStudentForm_Click);
            // 
            // SongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 238);
            this.Controls.Add(this.tableLayoutSongForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SongForm";
            this.Text = "SongForm";
            this.Load += new System.EventHandler(this.SongForm_Load);
            this.tableLayoutSongForm.ResumeLayout(false);
            this.tableLayoutSongForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutSongForm;
        private System.Windows.Forms.Button cancelButtonSongForm;
        private System.Windows.Forms.Label authorLabelSongForm;
        private System.Windows.Forms.Label RecordDateLabelSongForm;
        private System.Windows.Forms.Label categoryLabelSongForm;
        private System.Windows.Forms.Label titleLabelSongForm;
        private System.Windows.Forms.DateTimePicker datePickerSongForm;
        private System.Windows.Forms.ComboBox comboCategorySongForm;
        private System.Windows.Forms.TextBox AuthorTextBoxSongForm;
        private System.Windows.Forms.TextBox TitleTextBoxSongForm;
        private System.Windows.Forms.Button AddButtonStudentForm;
    }
}