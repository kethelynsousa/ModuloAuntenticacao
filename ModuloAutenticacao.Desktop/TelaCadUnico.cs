using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAutenticacao.Desktop
{
    public partial class TelaCadUnico : Form
    {
        public TelaCadUnico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TelaNivel().Show(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtlogin.Enabled = false;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mensagebox(object sender, MouseEventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtlogin.Text = txtnome.Text;
            txtlogin.BackColor = Color.White;
            //Clever
            string[] nome = txtnome.Text.Split(' ');
            //txtLogin.Text = nome[0];
            //Yedo
            string substring = "";
            string[] subs = txtsobrenome.Text.Split();
            foreach (string sub in subs)
            {
                //  MessageBox.Show($"Substring: {sub}");
                substring = sub;
            }
            //===================
            txtlogin.Text = $"{nome[0].ToLower()}.{substring.ToLower()}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TelaNivel().Show();

        }
    }
}
