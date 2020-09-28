using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosLlaveCriptografica
{
    public class ValidarTextBox
    {
        public static void SoloNumeros(KeyPressEventArgs V)
        {
            if (char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
            }
        }
    }
}
