using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Envio
{
    public delegate void Ejecutar(String var);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Funcion(String var)
        {
            textBox1.Text = var;
            DialogResult resultado = MessageBox.Show("Texto Enviado", "Alerta", MessageBoxButtons.YesNoCancel);

            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Reiniciar la aplicacion");
                Application.Restart();
            }
            if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Ingrese una opcion v�lida.","Sugerencia");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)

        {
            Form2 ventana = new Form2();
            ventana.Envio = new Ejecutar(this.Funcion);
            ventana.ShowDialog();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}