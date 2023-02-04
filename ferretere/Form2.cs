using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferretere
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void butCargar_Click(object sender, EventArgs e)
        {
            string nombre=textNombre.Text;
            string contraseña=textContraseña.Text;

            Form1 programa= new Form1();
            if (nombre == "Brandon" && contraseña == "Zuazo1257")
            {
                programa.ShowDialog();
                this.Close();
            }
            else {
                textNombre.Text = "";
                textContraseña.Text = "";


            }
            programa.ShowDialog();
        }
    }
}
