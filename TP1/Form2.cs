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
    public partial class menuBaru : Form
    {
        Client user = new Client();
        FormBeli formBeli = new FormBeli(); 
        FormKtlg formKtlg = new FormKtlg();
        public menuBaru()
        {
            InitializeComponent();

        }

        private void menuBaru_Load(object sender, EventArgs e)
        {

        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            formBeli.Show(); //menampilkan form beli
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            formLogin formLogin = new formLogin(); //membuat login baru jika sudah menekan logout
            formLogin.Show();
            this.Hide();
        }

        private void btnKtlg_Click(object sender, EventArgs e)
        {
            formKtlg.Show();

        }
    }
}
