using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btncaixa_Click(object sender, EventArgs e)
        {
            sidepanel.Top = btncaixa.Top;
            caixa_Control1.BringToFront();
        }

        private void btnprodutos_Click(object sender, EventArgs e)
        {
            sidepanel.Top = btnprodutos.Top;
            produtos_Control1.BringToFront();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            sidepanel.Top = btnsair.Top;
        }

        private void caixa_Control1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
