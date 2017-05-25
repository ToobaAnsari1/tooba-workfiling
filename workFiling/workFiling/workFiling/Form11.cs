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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");
            comboBox6.Items.Add("D:\\");
            comboBox6.Items.Add("E:\\");
            richTextBox1.Visible = false;

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
            String wpath = comboBox1.Text + comboBox2.Text;
            DirectoryInfo Dir = new DirectoryInfo(wpath);
            FileInfo[] f = Dir.GetFiles();
            comboBox3.Items.Clear();
            foreach (FileInfo fi in f)
            {
                this.comboBox3.Items.Add(fi.Name.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            button3.Visible = true;
            string path = comboBox1.Text + comboBox2.Text + "\\" + comboBox3.Text;
            if (File.Exists(path))
            {
                byte[] bo = new byte[1000];
                char[] c = new char[1000];
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                fs.Read(bo, 0, bo.Length);
                Decoder d = Encoding.UTF8.GetDecoder();
                d.GetChars(bo, 0, bo.Length, c, 0);
                string s = new string(c);
                richTextBox1.Text = s;
                fs.Close();
            }

            else
            {
                MessageBox.Show("File not found.");
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox6.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            comboBox5.Items.Clear();
            foreach (DirectoryInfo di in d)
            {
                comboBox5.Items.Add(di.ToString());
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            String wpath = comboBox6.Text + comboBox5.Text;
            DirectoryInfo Dir = new DirectoryInfo(wpath);
            FileInfo[] f = Dir.GetFiles();
            comboBox4.Items.Clear();
            foreach (FileInfo fi in f)
            {
                this.comboBox4.Items.Add(fi.Name.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = comboBox6.Text + comboBox5.Text + "\\" + comboBox4.Text;
            if (File.Exists(path))
            {
                byte[] b = new byte[1000];
                char[] c = new char[1000];
                FileStream fs = new FileStream(path, FileMode.Append);
                c = richTextBox2.Text.ToCharArray();
                Encoder ee = Encoding.UTF8.GetEncoder();
                ee.GetBytes(c, 0, c.Length, b, 0, true);
                fs.Write(b, 0, b.Length);
                fs.Close();


                MessageBox.Show("File Edited");
            }
            else
            {
                MessageBox.Show("File not found.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            richTextBox1.Text="";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox6.Text = "";
            comboBox5.Text = "";
            comboBox4.Text = "";
            richTextBox2.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
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