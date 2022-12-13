using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_enlazada_circular
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Lista lista;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista = new Lista();
            MessageBox.Show("lista creada con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            lista.insertarNodo(x);
            textBox1.Clear(); textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
            lista.verLista(textBox3);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string busc = textBox1.Text;
            lista.buscarNodo(busc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string modi = textBox1.Text;
            string moid2 = textBox2.Text;
            lista.modificarnodo(modi,moid2);
            textBox1.Clear(); textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string eli = textBox1.Text;
            lista.eliminarnodo(eli);
            textBox1.Clear(); textBox1.Focus();
        }
    }
}
