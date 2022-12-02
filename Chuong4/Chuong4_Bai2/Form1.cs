using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, s=0;
            n= int.Parse(txtN.Text);
            String chuoi = "1";
            for(int i=1; i<=n; i++)
            {
                s = s + i;
            }
            for(int i=2; i<=n; i++)
            {
             
                    chuoi =  chuoi + " + " + i;
                
            }
            txtKq.Text= s.ToString();
            txtS.Text = chuoi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtS.Enabled = false;
            txtKq.Enabled = false;
        }
    }
}
