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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d)
            {
                comboBox2.Items.Add(di.ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String wpath = comboBox1.Text + comboBox2.Text;
            DirectoryInfo Dir = new DirectoryInfo(wpath);
            FileInfo[] f = Dir.GetFiles();
            foreach (FileInfo fi in f)
            {
                this.comboBox3.Items.Add(fi.Name.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Wpath = comboBox1.Text + comboBox2.Text + "\\" + comboBox3.Text;
            if (File.Exists(Wpath))
            {
                StreamWriter wd = new  StreamWriter(Wpath,append:true);
                 wd.Write(richTextBox1.Text);
                 MessageBox.Show("you Succcesfully write file");
                wd.Close();

                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                richTextBox1.Text = "";
           

            }
         
           
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
