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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.picOfMyself.BackgroundImage = Image.FromFile(this.pathImage.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong with your path");
            }
            
        }

        private void openImage_FileOk(object sender, CancelEventArgs e)
        {
            String path = openImage.FileName;
            this.pathImage.Text = path;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openImage.ShowDialog();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.picOfMyself.BackgroundImage = Image.FromFile(@"H:\C# .Net\Test\MyVeryFirstApp\Text_standardization\Text_standardization\image\IMG_20190626_192748.jpg");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label2.Text = this.comboBox1.SelectedIndex.ToString();
            this.label3.Text = this.comboBox1.Text;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.label2.Text = this.checkedListBox1.SelectedIndex.ToString();
            this.label3.Text = this.checkedListBox1.Text;
        }
    }
}
