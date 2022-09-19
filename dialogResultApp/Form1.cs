using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialogResultApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void buttonOtvori_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Odaberite Yes / No / Cancel", "Naslovna linija Dijaloga za poruke", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            switch (rez)

            {

                case DialogResult.Yes:

                    textBoxRezultat.Text = "Izabrali ste dugme YES";

                    break;

                case DialogResult.No:

                    textBoxRezultat.Text = "Izabrali ste dugme NO";

                    break;

                case DialogResult.Cancel:

                    textBoxRezultat.Text = "Izabrali ste dugme Cancel";

                    break;

            }

        }

    }

}

