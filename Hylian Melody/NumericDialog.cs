using System;
using System.Windows.Forms;

namespace HylianMelody
{
    public partial class NumericDialog : Form
    {
        public NumericDialog()
        {
            InitializeComponent();
        }

        public NumericDialog(string title, Decimal defaultValue)
        {
            InitializeComponent();
            Text = title;
            numericValue.Value = defaultValue;
        }

        public event EventHandler<Decimal> OnOK;

        private void buttonOK_Click(object sender, EventArgs e)
        {
            OnOK?.Invoke(sender, numericValue.Value);
            Close();
        }
    }
}
