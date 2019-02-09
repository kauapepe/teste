using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro c1 = new Carro("azul");
            Carro c2 = c1;
            c2.cor = "vermelho";
            label1.Text = c1.cor;
            label2.Text = c2.cor;


            /**
            unsafe
            {
                int a = 10;
                int* b = &a;

                *b = 2;

                label1.Text = a.ToString();
                label2.Text = b->ToString();
            }
            **/
        }

        private void coco(object coco1, EventArgs cocoEvento)
        {
           
        }

        private void teste(object t, KeyPressEventArgs e)
        {
            label2.Text = e.KeyChar.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_CausesValidationChanged(object sender, EventArgs e)
        {

        }

        private void button1_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {

        }
    }
}
