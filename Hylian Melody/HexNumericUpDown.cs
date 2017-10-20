using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HylianMelody
{
    public class HexNumericUpDown : System.Windows.Forms.NumericUpDown
    {
        public HexNumericUpDown()
        {
            Hexadecimal = true;
        }

        /*protected override void ValidateEditText()
        {
            if (base.UserEdit)
            {
                base.ValidateEditText();
            }
        }*/

        protected override void UpdateEditText()
        {
            Text = ((Value < 0) ? ("-") : (Convert.ToInt64(base.Value).ToString("X" + HexLength)));
        }

        [System.ComponentModel.DefaultValue(2)]
        public int HexLength
        {
            get { return m_nHexLength; }
            set { m_nHexLength = value; }
        }

        public new System.Int64 Value
        {
            get { return System.Convert.ToInt64(base.Value); }
            set { base.Value = System.Convert.ToDecimal(value); }
        }

        private int m_nHexLength = 2;
    }
}
