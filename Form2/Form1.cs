using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form2.ServiceReference1;

namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tinh_Click(object sender, EventArgs e)
        {
            CalServiceClient ob =new CalServiceClient();
            kq.Text=ob.Add(double.Parse(a.Text),double.Parse(b.Text)).ToString();//goi dich vu
        }
    }
}
