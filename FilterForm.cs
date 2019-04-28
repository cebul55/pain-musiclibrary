using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pik_biblioteka_muzyczna {
    public partial class FilterForm : Form {
        public FilterForm() {
            InitializeComponent();
        }

        public DateTime MinDateValue {
            get { return minDatePickerFilterForm.Value.Date; }
        }

        public DateTime MaxDateValue {
            get { return maxDatePickerFilterForm.Value.Date; }
        }

        private void FilterForm_Load(object sender, EventArgs e) {
            minDatePickerFilterForm.Value = System.DateTime.Now.Date;
            maxDatePickerFilterForm.Value = System.DateTime.Now.Date;
        }

        private void OkButtonFilterForm_Click(object sender, EventArgs e) {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        private void CancelButtonFilterForm_Click(object sender, EventArgs e) {
                DialogResult = DialogResult.Cancel;
        }

        private void maxDatePicker_Validating(object sender, CancelEventArgs e) {
            try {
                DateTime minDate = minDatePickerFilterForm.Value;
                DateTime maxDate = maxDatePickerFilterForm.Value;
                if (minDate > maxDate)
                    throw new Exception("Minimum date cannot be grater than maximum date.");
            }
            catch (Exception exception) {
                e.Cancel = true;
                errorProviderFilterForm.SetError(maxDatePickerFilterForm, exception.Message);
            }
        }

        private void maxDatePicker_Validated(object sender, EventArgs e) {
            errorProviderFilterForm.SetError(maxDatePickerFilterForm, "");
        }
    }
}
