namespace Text_standardization
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.picOfMyself = new System.Windows.Forms.PictureBox();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.pathImage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOfMyself)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 194);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM TIÊU CHUẨN HÓA VĂN BẢN.\r\n\r\nPhần mềm có khả năng phát hiện và tự động sửa" +
    " các lỗi đánh máy lên đến 99%\r\n\r\nAuthor  : Nguyễn Việt Hải\r\nVersion: 1.0.\r\nLast " +
    "update: 03/25/2022.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // picOfMyself
            // 
            this.picOfMyself.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picOfMyself.Location = new System.Drawing.Point(183, 220);
            this.picOfMyself.Name = "picOfMyself";
            this.picOfMyself.Size = new System.Drawing.Size(472, 358);
            this.picOfMyself.TabIndex = 1;
            this.picOfMyself.TabStop = false;
            // 
            // openImage
            // 
            this.openImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openImage_FileOk);
            // 
            // pathImage
            // 
            this.pathImage.Location = new System.Drawing.Point(280, 586);
            this.pathImage.Name = "pathImage";
            this.pathImage.Size = new System.Drawing.Size(304, 20);
            this.pathImage.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = ":/...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 647);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pathImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picOfMyself);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picOfMyself)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picOfMyself;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.TextBox pathImage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}