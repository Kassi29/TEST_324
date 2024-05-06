using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace NUEVE
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
        }
        //crear
        ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient();
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox2.Text;
            string apellido = textBox3.Text;
            string telefono = textBox4.Text;
            bool tipo = true; // Asumiendo que el tipo es verdadero por defecto
            string resultado = ws.Crea(nombre, apellido, telefono, tipo);
            MessageBox.Show(resultado);
        }

        //modificar
        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string nombre = textBox2.Text;
            string apellido = textBox3.Text;
            string telefono = textBox4.Text;
            bool tipo = true; // Asumiendo que el tipo es verdadero por defecto
            string resultado = ws.Modifica(id, nombre, apellido, telefono, tipo);
        }
        //eliminar
        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient();
            int id = Convert.ToInt32(textBox1.Text);
            ws.Elimina(id);
            MessageBox.Show("Persona eliminada correctamente.");
        }
    }
}
