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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");
            this.ControlBox=false;
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
           
            
            string sfpath = comboBox1.Text + comboBox2.Text + "\\" + textBox1.Text;
           if(Directory.Exists(sfpath))
           
            {
                MessageBox.Show("Folder Already Exist!");
            }
            else
            {
                Directory.CreateDirectory(sfpath);
                MessageBox.Show("Folder Created");
            }

           comboBox1.Text = "";
           comboBox2.Text = "";
           textBox1.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
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
