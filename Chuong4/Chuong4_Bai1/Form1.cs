using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_bai1
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
            txtSoLonNhat.Enabled = false;
            txtSoNhoNhat.Enabled = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            c = int.Parse(txtC.Text);

            int max;
            max =Math.Max(c, Math.Max(a, b));
            txtSoLonNhat.Text = max.ToString();
            int min = Math.Min(a, Math.Min(b, c));
            txtSoNhoNhat.Text = min.ToString();





        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
