using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidu4._3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double so1; 
                so1= double.Parse(txtSoThuNhat.Text);
            double so2;
                so2= double.Parse(txtSoThuHai.Text);
            double kq = 0;
            if (cmbPheptinh.Text == "+") kq = so1 + so2;
            if (cmbPheptinh.Text == "-") kq = so1 - so2;
            if (cmbPheptinh.Text == "*") kq = so1 * so2;
            if (cmbPheptinh.Text == "/") kq = so1 / so2;
            txtSoThuBa.Text = kq.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSoThuBa.Enabled = false;
        }
    }
}
