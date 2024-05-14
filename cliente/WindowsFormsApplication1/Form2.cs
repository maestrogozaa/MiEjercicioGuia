using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{    
    public partial class Form2 : Form
    {
        int nForm;
        Socket server;
        public Form2(int nForm, Socket server)
        {
            InitializeComponent();
            this.nForm = nForm;
            this.server = server;
        }

        public void TomaRespuesta1(string mensaje)
        {
            MessageBox.Show("Longitud de tu nombre: " + mensaje + " letras.");
        }

        public void TomaRespuesta2(string mensaje)
        {
            if (mensaje == "SI") MessageBox.Show("Tu nombre SI es bonito.");
            else MessageBox.Show("Tu nombre NO es bonito, lo siento.");
        }

        public void TomaRespuesta3(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void TomaRespuesta4(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void TomaRespuesta5(string mensaje)
        {
            MessageBox.Show(mensaje);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (Longitud.Checked)
            {
                string mensaje = "1/" + nForm + "/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

            }
            else if (Bonito.Checked)
            {
                string mensaje = "2/" + nForm + "/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

            }
            else if (Alto.Checked)
            {
                // Enviamos nombre y altura
                string mensaje = "3/" + nForm + "/" + nombre.Text + "/" + alturaBox.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            else if (Palindromo.Checked)
            {
                // Enviamos nombre
                string mensaje = "4/" + nForm + "/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            else if (Mayusculas.Checked)
            {
                // Enviamos nombre
                string mensaje = "5/" + nForm + "/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            nFormLbl.Text = nForm.ToString();
        }
    }
}
