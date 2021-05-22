
namespace RAMAZANARSLANTÜRK_170201025
{
    partial class Form1
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
            this.vScrollBar4 = new System.Windows.Forms.VScrollBar();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Replace_btn = new System.Windows.Forms.Button();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Gama_btn = new System.Windows.Forms.Button();
            this.Contrast_btn = new System.Windows.Forms.Button();
            this.Brightness_btn = new System.Windows.Forms.Button();
            this.Sharpen_8_btn = new System.Windows.Forms.Button();
            this.Sharpen_4_btn = new System.Windows.Forms.Button();
            this.Edge_8_btn = new System.Windows.Forms.Button();
            this.Edge_4_btn = new System.Windows.Forms.Button();
            this.Median_btn = new System.Windows.Forms.Button();
            this.Gaussian_btn = new System.Windows.Forms.Button();
            this.MeanFilter_btn = new System.Windows.Forms.Button();
            this.GrayScale_btn = new System.Windows.Forms.Button();
            this.Load_btn = new System.Windows.Forms.Button();
            this.pictureBox_Destination = new System.Windows.Forms.PictureBox();
            this.pictureBox_Source = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Destination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Source)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar4
            // 
            this.vScrollBar4.LargeChange = 7;
            this.vScrollBar4.Location = new System.Drawing.Point(593, 452);
            this.vScrollBar4.Maximum = 30;
            this.vScrollBar4.Minimum = 1;
            this.vScrollBar4.Name = "vScrollBar4";
            this.vScrollBar4.Size = new System.Drawing.Size(45, 27);
            this.vScrollBar4.TabIndex = 47;
            this.vScrollBar4.Value = 10;
            this.vScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar4_Scroll);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(553, 451);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(37, 29);
            this.textBox4.TabIndex = 46;
            this.textBox4.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Kernel Windows Size :";
            // 
            // Replace_btn
            // 
            this.Replace_btn.Location = new System.Drawing.Point(444, 150);
            this.Replace_btn.Name = "Replace_btn";
            this.Replace_btn.Size = new System.Drawing.Size(94, 29);
            this.Replace_btn.TabIndex = 44;
            this.Replace_btn.Text = "<==";
            this.Replace_btn.UseVisualStyleBackColor = true;
            this.Replace_btn.Click += new System.EventHandler(this.Replace_btn_Click);
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.LargeChange = 7;
            this.vScrollBar3.Location = new System.Drawing.Point(593, 417);
            this.vScrollBar3.Maximum = 255;
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(45, 27);
            this.vScrollBar3.TabIndex = 43;
            this.vScrollBar3.Value = 3;
            this.vScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar3_Scroll);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.LargeChange = 7;
            this.vScrollBar2.Location = new System.Drawing.Point(593, 383);
            this.vScrollBar2.Maximum = 255;
            this.vScrollBar2.Minimum = -255;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(45, 27);
            this.vScrollBar2.TabIndex = 41;
            this.vScrollBar2.Value = 3;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 2;
            this.vScrollBar1.Location = new System.Drawing.Point(253, 512);
            this.vScrollBar1.Maximum = 10;
            this.vScrollBar1.Minimum = 3;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(45, 27);
            this.vScrollBar1.SmallChange = 2;
            this.vScrollBar1.TabIndex = 34;
            this.vScrollBar1.Value = 3;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(553, 415);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(37, 29);
            this.textBox3.TabIndex = 42;
            this.textBox3.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(553, 381);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 29);
            this.textBox2.TabIndex = 40;
            this.textBox2.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 512);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 29);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = "3";
            // 
            // Gama_btn
            // 
            this.Gama_btn.Location = new System.Drawing.Point(453, 450);
            this.Gama_btn.Name = "Gama_btn";
            this.Gama_btn.Size = new System.Drawing.Size(94, 29);
            this.Gama_btn.TabIndex = 39;
            this.Gama_btn.Text = "Gama";
            this.Gama_btn.UseVisualStyleBackColor = true;
            this.Gama_btn.Click += new System.EventHandler(this.Gama_btn_Click);
            // 
            // Contrast_btn
            // 
            this.Contrast_btn.Location = new System.Drawing.Point(453, 415);
            this.Contrast_btn.Name = "Contrast_btn";
            this.Contrast_btn.Size = new System.Drawing.Size(94, 29);
            this.Contrast_btn.TabIndex = 38;
            this.Contrast_btn.Text = "Contrast";
            this.Contrast_btn.UseVisualStyleBackColor = true;
            this.Contrast_btn.Click += new System.EventHandler(this.Contrast_btn_Click);
            // 
            // Brightness_btn
            // 
            this.Brightness_btn.Location = new System.Drawing.Point(453, 380);
            this.Brightness_btn.Name = "Brightness_btn";
            this.Brightness_btn.Size = new System.Drawing.Size(94, 29);
            this.Brightness_btn.TabIndex = 37;
            this.Brightness_btn.Text = "Brightness";
            this.Brightness_btn.UseVisualStyleBackColor = true;
            this.Brightness_btn.Click += new System.EventHandler(this.Brightness_btn_Click);
            // 
            // Sharpen_8_btn
            // 
            this.Sharpen_8_btn.Location = new System.Drawing.Point(353, 415);
            this.Sharpen_8_btn.Name = "Sharpen_8_btn";
            this.Sharpen_8_btn.Size = new System.Drawing.Size(94, 29);
            this.Sharpen_8_btn.TabIndex = 36;
            this.Sharpen_8_btn.Text = "Sharpen 8";
            this.Sharpen_8_btn.UseVisualStyleBackColor = true;
            this.Sharpen_8_btn.Click += new System.EventHandler(this.Sharpen_8_btn_Click);
            // 
            // Sharpen_4_btn
            // 
            this.Sharpen_4_btn.Location = new System.Drawing.Point(353, 380);
            this.Sharpen_4_btn.Name = "Sharpen_4_btn";
            this.Sharpen_4_btn.Size = new System.Drawing.Size(94, 29);
            this.Sharpen_4_btn.TabIndex = 35;
            this.Sharpen_4_btn.Text = "Sharpen 4";
            this.Sharpen_4_btn.UseVisualStyleBackColor = true;
            this.Sharpen_4_btn.Click += new System.EventHandler(this.Sharpen_4_btn_Click);
            // 
            // Edge_8_btn
            // 
            this.Edge_8_btn.Location = new System.Drawing.Point(253, 415);
            this.Edge_8_btn.Name = "Edge_8_btn";
            this.Edge_8_btn.Size = new System.Drawing.Size(94, 29);
            this.Edge_8_btn.TabIndex = 33;
            this.Edge_8_btn.Text = "Edge 8";
            this.Edge_8_btn.UseVisualStyleBackColor = true;
            this.Edge_8_btn.Click += new System.EventHandler(this.Edge_8_btn_Click);
            // 
            // Edge_4_btn
            // 
            this.Edge_4_btn.Location = new System.Drawing.Point(253, 380);
            this.Edge_4_btn.Name = "Edge_4_btn";
            this.Edge_4_btn.Size = new System.Drawing.Size(94, 29);
            this.Edge_4_btn.TabIndex = 31;
            this.Edge_4_btn.Text = "Edge 4";
            this.Edge_4_btn.UseVisualStyleBackColor = true;
            this.Edge_4_btn.Click += new System.EventHandler(this.Edge_4_btn_Click);
            // 
            // Median_btn
            // 
            this.Median_btn.Location = new System.Drawing.Point(153, 450);
            this.Median_btn.Name = "Median_btn";
            this.Median_btn.Size = new System.Drawing.Size(94, 29);
            this.Median_btn.TabIndex = 30;
            this.Median_btn.Text = "Median";
            this.Median_btn.UseVisualStyleBackColor = true;
            this.Median_btn.Click += new System.EventHandler(this.Median_btn_Click);
            // 
            // Gaussian_btn
            // 
            this.Gaussian_btn.Location = new System.Drawing.Point(153, 415);
            this.Gaussian_btn.Name = "Gaussian_btn";
            this.Gaussian_btn.Size = new System.Drawing.Size(94, 29);
            this.Gaussian_btn.TabIndex = 29;
            this.Gaussian_btn.Text = "Gaussian";
            this.Gaussian_btn.UseVisualStyleBackColor = true;
            this.Gaussian_btn.Click += new System.EventHandler(this.Gaussian_btn_Click);
            // 
            // MeanFilter_btn
            // 
            this.MeanFilter_btn.Location = new System.Drawing.Point(153, 380);
            this.MeanFilter_btn.Name = "MeanFilter_btn";
            this.MeanFilter_btn.Size = new System.Drawing.Size(94, 29);
            this.MeanFilter_btn.TabIndex = 28;
            this.MeanFilter_btn.Text = "Mean Filter";
            this.MeanFilter_btn.UseVisualStyleBackColor = true;
            this.MeanFilter_btn.Click += new System.EventHandler(this.MeanFilter_btn_Click);
            // 
            // GrayScale_btn
            // 
            this.GrayScale_btn.Location = new System.Drawing.Point(53, 380);
            this.GrayScale_btn.Name = "GrayScale_btn";
            this.GrayScale_btn.Size = new System.Drawing.Size(94, 29);
            this.GrayScale_btn.TabIndex = 27;
            this.GrayScale_btn.Text = "GrayScale";
            this.GrayScale_btn.UseVisualStyleBackColor = true;
            this.GrayScale_btn.Click += new System.EventHandler(this.GrayScale_btn_Click);
            // 
            // Load_btn
            // 
            this.Load_btn.Location = new System.Drawing.Point(198, 17);
            this.Load_btn.Name = "Load_btn";
            this.Load_btn.Size = new System.Drawing.Size(94, 29);
            this.Load_btn.TabIndex = 26;
            this.Load_btn.Text = "Load";
            this.Load_btn.UseVisualStyleBackColor = true;
            this.Load_btn.Click += new System.EventHandler(this.Load_btn_Click);
            // 
            // pictureBox_Destination
            // 
            this.pictureBox_Destination.Location = new System.Drawing.Point(576, 53);
            this.pictureBox_Destination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_Destination.Name = "pictureBox_Destination";
            this.pictureBox_Destination.Size = new System.Drawing.Size(373, 320);
            this.pictureBox_Destination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Destination.TabIndex = 25;
            this.pictureBox_Destination.TabStop = false;
            // 
            // pictureBox_Source
            // 
            this.pictureBox_Source.Location = new System.Drawing.Point(33, 53);
            this.pictureBox_Source.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_Source.Name = "pictureBox_Source";
            this.pictureBox_Source.Size = new System.Drawing.Size(373, 320);
            this.pictureBox_Source.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Source.TabIndex = 24;
            this.pictureBox_Source.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 583);
            this.Controls.Add(this.vScrollBar4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Replace_btn);
            this.Controls.Add(this.vScrollBar3);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Gama_btn);
            this.Controls.Add(this.Contrast_btn);
            this.Controls.Add(this.Brightness_btn);
            this.Controls.Add(this.Sharpen_8_btn);
            this.Controls.Add(this.Sharpen_4_btn);
            this.Controls.Add(this.Edge_8_btn);
            this.Controls.Add(this.Edge_4_btn);
            this.Controls.Add(this.Median_btn);
            this.Controls.Add(this.Gaussian_btn);
            this.Controls.Add(this.MeanFilter_btn);
            this.Controls.Add(this.GrayScale_btn);
            this.Controls.Add(this.Load_btn);
            this.Controls.Add(this.pictureBox_Destination);
            this.Controls.Add(this.pictureBox_Source);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Destination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Replace_btn;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Gama_btn;
        private System.Windows.Forms.Button Contrast_btn;
        private System.Windows.Forms.Button Brightness_btn;
        private System.Windows.Forms.Button Sharpen_8_btn;
        private System.Windows.Forms.Button Sharpen_4_btn;
        private System.Windows.Forms.Button Edge_8_btn;
        private System.Windows.Forms.Button Edge_4_btn;
        private System.Windows.Forms.Button Median_btn;
        private System.Windows.Forms.Button Gaussian_btn;
        private System.Windows.Forms.Button MeanFilter_btn;
        private System.Windows.Forms.Button GrayScale_btn;
        private System.Windows.Forms.Button Load_btn;
        private System.Windows.Forms.PictureBox pictureBox_Destination;
        private System.Windows.Forms.PictureBox pictureBox_Source;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

