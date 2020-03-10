using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class FormKtlg : Form
    {
        public FormKtlg()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //akan menampilkan menu sebelumnya jika menekan back
            menuBaru menuBaru = new menuBaru();
            menuBaru.Show();
            this.Hide();
        }
    }
}
