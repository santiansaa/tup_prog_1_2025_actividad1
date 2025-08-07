using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piedra_papel_tijera
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string nombre;
            Form2 player = new Form2();
            if (player.ShowDialog() == DialogResult.OK) 
            {
                
                string nombre = player.txtNombre.Text;
                Jugador jugador = new Jugador(nombre);
                listBox1.Items.Add(nombre);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ppt = new Form3();
            if (ppt.ShowDialog() == DialogResult.OK) 
            { }
        }
    }
}
