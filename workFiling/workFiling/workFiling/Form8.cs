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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");


            comboBox4.Items.Add("D:\\");
            comboBox4.Items.Add("E:\\");

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Mpath = comboBox1.Text + comboBox2.Text;
            DirectoryInfo Dir = new DirectoryInfo(Mpath);
            FileInfo[] f = Dir.GetFiles();
            comboBox3.Items.Clear();
            foreach (FileInfo fi in f)
            {
                this.comboBox3.Items.Add(fi.Name.ToString());
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox4.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            comboBox5.Items.Clear();
            foreach (DirectoryInfo di in d)
            {
                comboBox5.Items.Add(di.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String Mpath = comboBox1.Text + comboBox2.Text + "\\" + comboBox3.Text;
            string Ppath = comboBox4.Text + comboBox5.Text + "\\" + comboBox3.Text;
            if (File.Exists(Mpath))
            {
                File.Move(Mpath, Ppath);

                MessageBox.Show("File Moved");

            }
            else
            {
                MessageBox.Show("File does not Exist");
            }
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
