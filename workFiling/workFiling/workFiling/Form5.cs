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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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
            comboBox2.Items.Clear();
            foreach (DirectoryInfo di in d)
            {
                comboBox2.Items.Add(di.ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sepath = comboBox1.Text + comboBox2.Text;
            DirectoryInfo Dir = new DirectoryInfo(sepath);
            FileInfo[] f = Dir.GetFiles();
            comboBox3.Items.Clear();
            foreach (FileInfo fi in f)
            {
                this.comboBox3.Items.Add(fi.Name.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {  String sepath = comboBox1.Text + comboBox2.Text + "\\" + comboBox3.Text;

            if (File.Exists(sepath))
            {
                File.Delete(sepath);
                MessageBox.Show("File deleted");
            }
            else
            {


                MessageBox.Show("File does not exists");
            }
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
          
                
            }

        private void label5_Click(object sender, EventArgs e)
        {
               Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
            
            
          
        }

      

      
    }

