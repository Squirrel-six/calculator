﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
           var x = int.Parse(this.textBox1.Text);
           var y = int.Parse(this.textBox2.Text);
           var z = x + y;
            this.labelresult.Text = z.ToString();
            
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBox1.Text);
            var y = int.Parse(this.textBox2.Text);
            var z = x - y;
            this.labelresult.Text = z.ToString();
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBox1.Text);
            var y = int.Parse(this.textBox2.Text);
            var z = x * y;
            this.labelresult.Text = z.ToString();
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBox1.Text);
            var y = int.Parse(this.textBox2.Text);
            var z = x / y;
            this.labelresult.Text = z.ToString();
        }
    }
}
