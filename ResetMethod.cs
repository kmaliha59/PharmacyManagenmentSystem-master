using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagenmentSystem
{
    public class ResetMethod
    {
         public static void Reset(Control.ControlCollection ctrlCollection)
        {
            foreach (Control control in ctrlCollection)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                if (control is  ComboBox comboBox )
                {
                    comboBox.Text = "";
                }
                if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Text = "";
                }
            }
        }
    }
}
