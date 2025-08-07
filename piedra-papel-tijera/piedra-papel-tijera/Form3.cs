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
    public partial class Form3 : Form
    {
        int elemento;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elemento = 0;
            //piedra
        }

        private void button2_Click(object sender, EventArgs e)
        {
            elemento = 1;
            //papel
        }

        private void button3_Click(object sender, EventArgs e)
        {
            elemento = 2;
            //tijera
        }
    }
}
