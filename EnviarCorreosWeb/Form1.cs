using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviarCorreosWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Correo email = new Correo();
            email.para = txtPara.Text;
            email.asunto = txtAsunto.Text;
            email.mensaje = txtMensaje.Text;
            if ((email.para != "")|| (email.asunto != "")|| (email.mensaje !=""))
            {
                email.endMail(email.para, email.asunto, email.mensaje);
                MessageBox.Show("******MENSAJE ENVIADO******");
                txtPara.Clear();
                txtAsunto.Clear();
                txtMensaje.Clear();
            }
            else
            {
                MessageBox.Show("OCURRIO UN ERROR AL ENVIAR EL MENSAJE");
            }
        }


    }
}
