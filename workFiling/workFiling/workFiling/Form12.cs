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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");
            this.ControlBox = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
              string fopath = comboBox1.Text + "\\" + textBox1.Text;
           if(Directory.Exists(fopath))
            {
                MessageBox.Show("Folder Already Exist!");
            }
            else
            {

                Directory.CreateDirectory(fopath);
                MessageBox.Show("Folder Created");
            }
           comboBox1.Text = "";
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

