using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace workFiling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            checkBox2.Visible = true;
            checkBox3.Visible = true;

            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            checkBox8.Visible = true;
            checkBox9.Visible = true;

            checkBox1.Visible = false;
            checkBox10.Visible = false;
            checkBox11.Visible = true;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;

            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox1.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            checkBox10.Visible = false;
            checkBox11.Visible = false;
        }

      

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {

            checkBox1.Visible = true;

            checkBox10.Visible = true;

            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox11.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Hide();
        }

      
    }
}
