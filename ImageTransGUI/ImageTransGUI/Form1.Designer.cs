namespace ImageTransGUI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadImage = new System.Windows.Forms.Button();
            this.pictureBoxReturn = new System.Windows.Forms.PictureBox();
            this.pictureBoxRead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRead)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadImage
            // 
            this.ReadImage.Location = new System.Drawing.Point(62, 36);
            this.ReadImage.Name = "ReadImage";
            this.ReadImage.Size = new System.Drawing.Size(75, 23);
            this.ReadImage.TabIndex = 0;
            this.ReadImage.Text = "读取图像";
            this.ReadImage.UseVisualStyleBackColor = true;
            this.ReadImage.Click += new System.EventHandler(this.ReadImage_Click);
            // 
            // pictureBoxReturn
            // 
            this.pictureBoxReturn.Location = new System.Drawing.Point(633, 94);
            this.pictureBoxReturn.Name = "pictureBoxReturn";
            this.pictureBoxReturn.Size = new System.Drawing.Size(576, 526);
            this.pictureBoxReturn.TabIndex = 1;
            this.pictureBoxReturn.TabStop = false;
            // 
            // pictureBoxRead
            // 
            this.pictureBoxRead.Location = new System.Drawing.Point(75, 94);
            this.pictureBoxRead.Name = "pictureBoxRead";
            this.pictureBoxRead.Size = new System.Drawing.Size(520, 526);
            this.pictureBoxRead.TabIndex = 2;
            this.pictureBoxRead.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 768);
            this.Controls.Add(this.pictureBoxRead);
            this.Controls.Add(this.pictureBoxReturn);
            this.Controls.Add(this.ReadImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadImage;
        private System.Windows.Forms.PictureBox pictureBoxReturn;
        private System.Windows.Forms.PictureBox pictureBoxRead;
    }
}

