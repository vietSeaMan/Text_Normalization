using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Text_standardization
{
    public partial class Form1 : Form
    {
        ExecutionText CheckText = new ExecutionText();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.outputTextBox.Text = CheckText.execution(this.inputTextBox.Text);
            this.outputTextBox.Text = CheckText.execution(this.outputTextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
