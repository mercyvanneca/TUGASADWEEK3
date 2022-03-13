using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUGASADWEEK3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Process_Click(object sender, EventArgs e)
        {
            String input = TextBox.Text;
            string a, b;
            b = TextBox.Text;
            a = b.Substring(4);
            if (input.Contains("ISI:") == true)
                Label_Empty.Text = a;
            if (input.Contains("WARNA:BIRU") == true)
                Label_Empty.ForeColor = Color.Blue;
            if (input.Contains("WARNA:MERAH") == true)
                Label_Empty.ForeColor = Color.Red;
            if (input.Contains("WARNA:HIJAU") == true)
                Label_Empty.ForeColor = Color.Green;
            if (input.Contains("HIDE") == true)
            {
                Label_Empty.Visible = true;
                {
                    Label_Empty.Show();
                    Label_Empty.Hide();
                }
            }
            if (input.Contains("SHOW") == true)
            {
                Label_Empty.Visible = true;
                {
                    Label_Empty.Hide();
                    Label_Empty.Show();
                }
            }

        } 

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_Empty_Click(object sender, EventArgs e)
        {

        }
    }
}
