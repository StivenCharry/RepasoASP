using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadoVariables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumero.Text = "1";
        }

        private void BtnIncrementar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = (Convert.ToInt32(txtNumero.Text) + 1).ToString();
        }
    }
}
