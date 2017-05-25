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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            this.Text =" Random Access";
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");
            this.ControlBox = false;

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] d = dir.GetDirectories();
          
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            comboBox2.Items.Clear();
            foreach (DirectoryInfo di in d)
            {
                comboBox2.Items.Add(di.ToString());
            }
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
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
        {
            byte[] bb = new byte[1000];
            char[] cc = new char[1000];
            string vname = comboBox1.Text + comboBox2.Text +"\\"+ comboBox3.Text;
            FileStream s = new FileStream(vname, FileMode.Open);
            s.Seek(8, SeekOrigin.Begin);
            s.Read(bb, 0, bb.Length);
            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(bb, 0, 499, cc, 0);
            string ss= new string(cc);
            textBox1.Text = ss;
            s.Close();


          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = "";
        }
    }
}
