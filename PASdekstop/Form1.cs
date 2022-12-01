using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASdekstop
{
    public partial class Form1 : Form
    {
        readonly string Username = "Bhre Nabil";
        readonly string Password = "1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Username && textBox2.Text == Password)
                {
                    MessageBox.Show("Kamu berhasil login");
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Kamu belum mengisi form login");
                }
                else
                {
                    MessageBox.Show("Username atau Password Salah ");
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Warning!!!", "Yakin Ingin Keluar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
                Application.Exit();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
