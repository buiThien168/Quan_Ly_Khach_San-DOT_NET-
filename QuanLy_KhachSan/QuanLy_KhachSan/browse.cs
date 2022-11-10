using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLy_KhachSan
{
    public partial class browse : Form
    {
        WebBrowser wb;
        public browse()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            wb = new WebBrowser();
            wb.Width = 700;
            wb.Height = 400;
            panel1.Controls.Add(wb);
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            string link = txt.Text;
            wb.Navigate(link);
        }

        
    }
}
