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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        //button login
        private void btnLogin_Click(object sender, EventArgs e)

        {
            
            Client user = new Client();
            String username = textBox1.Text; //string username
            String password = textBox2.Text; //string pass
            if (textBox1.Text == "") //uname tidak boleh kosong
            {
                MessageBox.Show("Username tidak boleh kosong");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Username tidak boleh kosong");
            }
            else
            {//jika masukan username&password bukan user dan pbo123 makalogin gagal 
                if (textBox1.Text != "user" && textBox2.Text != "pbo123")
                {
                    MessageBox.Show("LOGIN GAGAL");
                }
                else
                {
                    MessageBox.Show("LOGIN BERHASIL! SELAMAT DATANG");
                    menuBaru menu = new menuBaru();
                    menu.Show();
                    this.Visible = false;
                }
            }
        }

        //butto exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
