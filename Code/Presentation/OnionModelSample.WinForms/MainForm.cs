using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OnionModelSample.Framework.Properties;

namespace OnionModelSample.WinForms
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
            MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MessageBoxManager.Unregister();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBoxManager.Yes = LocalResource.Yes;
            MessageBoxManager.No = LocalResource.No;
            MessageBoxManager.Register();
            MessageBox.Show("Anda yakin sekali rupanya?", "Apa ini?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            MessageBoxManager.Unregister();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogJenaka dlg = new DialogJenaka();

            dlg.ShowDialog();

            if (dlg.DialogResult == DialogResult.Yes)
                lblBawah.Text = "Anda merasa ini semua lucu adanya. [Kompor Gas!]";
            else if (dlg.DialogResult == DialogResult.No)
                lblBawah.Text = "Anda tidak juga dibuatnya tertawa. [Gak Lucu!]";

            dlg.Dispose();
        }
    }
}
