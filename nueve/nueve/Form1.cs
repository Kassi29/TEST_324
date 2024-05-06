using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nueve
{
    public partial class Form1 : Form
    {
      
        private ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string nombre = textBox2.Text;
            string apellido = textBox3.Text;
            string telefono = textBox4.Text;
            bool tipo = checkBox1.Checked;

            // Llamar al método Modifica del servicio web
            string resultado = ws.Modifica(id, nombre, apellido, telefono, tipo);
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string nombre = textBox2.Text;
            string apellido = textBox3.Text;
            string telefono = textBox4.Text;
            bool tipo = checkBox1.Checked;

            // Llamar al método Crea del servicio web
            string resultado = ws.Crea(nombre, apellido, telefono, tipo);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ws.Elimina(Convert.ToInt16(textBox1.Text));
        }

        
    }
}
