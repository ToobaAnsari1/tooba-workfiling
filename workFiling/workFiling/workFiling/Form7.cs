using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace workFiling
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");

            comboBox3.Visible = false;
            button1.Visible = false;
            label3.Visible = false;

            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            comboBox2.Items.Clear();
            foreach (DirectoryInfo di in d)
            {
                comboBox2.Items.Add(di.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox3.Visible = true;
            label3.Visible = true;
            String spath = comboBox1.Text + comboBox2.Text;
            DirectoryInfo Dir = new DirectoryInfo(spath);
            FileInfo[] f = Dir.GetFiles();
            foreach (FileInfo fi in f)
            {
                this.comboBox3.Items.Add ( fi.Name.ToString());
               
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
