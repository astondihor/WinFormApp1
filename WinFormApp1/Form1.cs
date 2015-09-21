using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormApp1
{
    public partial class MainForm : Form
    {
            

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Yes = "Ya";
            MessageBoxManager.No = "Tidak";
            MessageBoxManager.Register();
            MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Keluar", MessageBoxButtons.YesNo);
            MessageBoxManager.Unregister();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBoxManager.Yes = LocalResource.Yes;
            MessageBoxManager.No = LocalResource.No;
            MessageBoxManager.Register();
            MessageBox.Show("Anda yakin sekali rupanya?", "Apa ini?", MessageBoxButtons.YesNo);
            MessageBoxManager.Unregister();

        }
    }
}
