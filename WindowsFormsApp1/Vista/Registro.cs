using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Vista
{
    public partial class Registro : Form
    {
        Prueba P = new Prueba();
        public Registro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrador ad = new Administrador();
            ad.Nombre = textBox1.Text;
            ad.Apellido = textBox2.Text;
            ad.Rut = Convert.ToInt32(textBox3.Text);
            ad.Telefono = Convert.ToInt32(textBox4.Text);
            ad.Correo = textBox5.Text;
            P.Registrar(ad);
        }
    }
}
