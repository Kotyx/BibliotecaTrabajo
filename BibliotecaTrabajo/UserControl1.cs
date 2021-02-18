using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaTrabajo
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Random num = new Random();

            propiedadNumero += 1;

            label1.Text = num.Next(1,10).ToString();
            label2.Text = num.Next(1, 10).ToString();
            label3.Text = num.Next(1, 10).ToString();

            if(label1.Text == label2.Text && label1.Text == label3.Text)
            {   
                MessageBox.Show("Tres Numeros son iguales", "Has hiperganado enhorabuena", MessageBoxButtons.OK);
            }
            else
            {
                if(label1.Text == label2.Text || label1.Text == label3.Text || label2.Text == label3.Text)
                {
                    MessageBox.Show("Dos Numeros son iguales", "Has ganado enhorabuena", MessageBoxButtons.OK);
                }
            }
        }

        public int Vecesjugadas() => propiedadNumero;
    }
}
