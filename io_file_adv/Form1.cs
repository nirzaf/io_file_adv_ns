using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace io_file_adv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.fname_textBox1.Text = this.openFileDialog1.FileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.fname_textBox1.Text)==true )
            {
                 this.textBox2.Text= System.IO.File.GetCreationTime(this.fname_textBox1.Text).ToString();
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.fname_textBox1.Text) == true)
            {
               this.textBox2.Text = System.IO.File.GetLastWriteTime(this.fname_textBox1.Text).ToString();
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.fname_textBox1.Text) == true)
            {     
             this.textBox2.Text = System.IO.File.GetLastAccessTime(this.fname_textBox1.Text).ToString();
            }
    
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.fname_textBox1.Text) == true)
            {
                this.get_file_nametextBox1.Text = System.IO.Path.GetFileName(this.fname_textBox1.Text);
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.fname_textBox1.Text) == true)
            {
                this.ext_textBox3.Text = System.IO.Path.GetExtension (this.fname_textBox1.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.fname_textBox1.Text) == true)
            {
                this.file_nametextBox1.Text = System.IO.Path.GetFileNameWithoutExtension(this.fname_textBox1.Text);
            }
        }
    }
}
