namespace pik_biblioteka_muzyczna {
    partial class FilterForm {
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelFilterForm = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButtonFilterForm = new System.Windows.Forms.Button();
            this.okButtonFilterForm = new System.Windows.Forms.Button();
            this.minDateLabelFilterForm = new System.Windows.Forms.Label();
            this.maxDateLabelFilterForm = new System.Windows.Forms.Label();
            this.minDatePickerFilterForm = new System.Windows.Forms.DateTimePicker();
            this.maxDatePickerFilterForm = new System.Windows.Forms.DateTimePicker();
            this.errorProviderFilterForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanelFilterForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFilterForm)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelFilterForm
            // 
            this.tableLayoutPanelFilterForm.ColumnCount = 2;
            this.tableLayoutPanelFilterForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFilterForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFilterForm.Controls.Add(this.cancelButtonFilterForm, 1, 2);
            this.tableLayoutPanelFilterForm.Controls.Add(this.okButtonFilterForm, 0, 2);
            this.tableLayoutPanelFilterForm.Controls.Add(this.minDateLabelFilterForm, 0, 0);
            this.tableLayoutPanelFilterForm.Controls.Add(this.maxDateLabelFilterForm, 0, 1);
            this.tableLayoutPanelFilterForm.Controls.Add(this.minDatePickerFilterForm, 1, 0);
            this.tableLayoutPanelFilterForm.Controls.Add(this.maxDatePickerFilterForm, 1, 1);
            this.tableLayoutPanelFilterForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFilterForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFilterForm.Name = "tableLayoutPanelFilterForm";
            this.tableLayoutPanelFilterForm.RowCount = 3;
            this.tableLayoutPanelFilterForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelFilterForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelFilterForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanelFilterForm.Size = new System.Drawing.Size(468, 132);
            this.tableLayoutPanelFilterForm.TabIndex = 0;
            // 
            // cancelButtonFilterForm
            // 
            this.cancelButtonFilterForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButtonFilterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButtonFilterForm.Location = new System.Drawing.Point(237, 89);
            this.cancelButtonFilterForm.Name = "cancelButtonFilterForm";
            this.cancelButtonFilterForm.Size = new System.Drawing.Size(228, 40);
            this.cancelButtonFilterForm.TabIndex = 0;
            this.cancelButtonFilterForm.Text = "Cancel";
            this.cancelButtonFilterForm.UseVisualStyleBackColor = true;
            this.cancelButtonFilterForm.Click += new System.EventHandler(this.CancelButtonFilterForm_Click);
            // 
            // okButtonFilterForm
            // 
            this.okButtonFilterForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okButtonFilterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okButtonFilterForm.Location = new System.Drawing.Point(3, 89);
            this.okButtonFilterForm.Name = "okButtonFilterForm";
            this.okButtonFilterForm.Size = new System.Drawing.Size(228, 40);
            this.okButtonFilterForm.TabIndex = 1;
            this.okButtonFilterForm.Text = "OK";
            this.okButtonFilterForm.UseVisualStyleBackColor = true;
            this.okButtonFilterForm.Click += new System.EventHandler(this.OkButtonFilterForm_Click);
            // 
            // minDateLabelFilterForm
            // 
            this.minDateLabelFilterForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minDateLabelFilterForm.AutoSize = true;
            this.minDateLabelFilterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minDateLabelFilterForm.Location = new System.Drawing.Point(3, 0);
            this.minDateLabelFilterForm.Name = "minDateLabelFilterForm";
            this.minDateLabelFilterForm.Size = new System.Drawing.Size(228, 43);
            this.minDateLabelFilterForm.TabIndex = 2;
            this.minDateLabelFilterForm.Text = "Minimum Date";
            this.minDateLabelFilterForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxDateLabelFilterForm
            // 
            this.maxDateLabelFilterForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxDateLabelFilterForm.AutoSize = true;
            this.maxDateLabelFilterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxDateLabelFilterForm.Location = new System.Drawing.Point(3, 43);
            this.maxDateLabelFilterForm.Name = "maxDateLabelFilterForm";
            this.maxDateLabelFilterForm.Size = new System.Drawing.Size(228, 43);
            this.maxDateLabelFilterForm.TabIndex = 3;
            this.maxDateLabelFilterForm.Text = "Maximum Date Value";
            this.maxDateLabelFilterForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minDatePickerFilterForm
            // 
            this.minDatePickerFilterForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.minDatePickerFilterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minDatePickerFilterForm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.minDatePickerFilterForm.Location = new System.Drawing.Point(261, 3);
            this.minDatePickerFilterForm.Name = "minDatePickerFilterForm";
            this.minDatePickerFilterForm.Size = new System.Drawing.Size(180, 26);
            this.minDatePickerFilterForm.TabIndex = 4;
            // 
            // maxDatePickerFilterForm
            // 
            this.maxDatePickerFilterForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.maxDatePickerFilterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxDatePickerFilterForm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.maxDatePickerFilterForm.Location = new System.Drawing.Point(261, 46);
            this.maxDatePickerFilterForm.Name = "maxDatePickerFilterForm";
            this.maxDatePickerFilterForm.Size = new System.Drawing.Size(180, 26);
            this.maxDatePickerFilterForm.TabIndex = 5;
            this.maxDatePickerFilterForm.Validating += new System.ComponentModel.CancelEventHandler(this.maxDatePicker_Validating);
            this.maxDatePickerFilterForm.Validated += new System.EventHandler(this.maxDatePicker_Validated);
            // 
            // errorProviderFilterForm
            // 
            this.errorProviderFilterForm.ContainerControl = this;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 132);
            this.Controls.Add(this.tableLayoutPanelFilterForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.tableLayoutPanelFilterForm.ResumeLayout(false);
            this.tableLayoutPanelFilterForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFilterForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFilterForm;
        private System.Windows.Forms.Button cancelButtonFilterForm;
        private System.Windows.Forms.Button okButtonFilterForm;
        private System.Windows.Forms.Label minDateLabelFilterForm;
        private System.Windows.Forms.Label maxDateLabelFilterForm;
        private System.Windows.Forms.DateTimePicker minDatePickerFilterForm;
        private System.Windows.Forms.DateTimePicker maxDatePickerFilterForm;
        private System.Windows.Forms.ErrorProvider errorProviderFilterForm;
    }
}