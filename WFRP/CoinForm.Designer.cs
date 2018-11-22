namespace OneNote.WFRP
{
    partial class CoinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goldNum = new System.Windows.Forms.NumericUpDown();
            this.silverNum = new System.Windows.Forms.NumericUpDown();
            this.brassNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brassNum)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OneNote.WFRP.Properties.Resources.goldcrown;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OneNote.WFRP.Properties.Resources.silvershilling;
            this.pictureBox2.Location = new System.Drawing.Point(142, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OneNote.WFRP.Properties.Resources.brasspenny;
            this.pictureBox3.Location = new System.Drawing.Point(258, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gold Crown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Silver Shilling";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Brass Penny";
            // 
            // goldNum
            // 
            this.goldNum.DecimalPlaces = 2;
            this.goldNum.Location = new System.Drawing.Point(26, 94);
            this.goldNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.goldNum.Name = "goldNum";
            this.goldNum.Size = new System.Drawing.Size(60, 20);
            this.goldNum.TabIndex = 6;
            this.goldNum.ValueChanged += new System.EventHandler(this.input_ValueChanged);
            // 
            // silverNum
            // 
            this.silverNum.DecimalPlaces = 2;
            this.silverNum.Location = new System.Drawing.Point(142, 94);
            this.silverNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.silverNum.Name = "silverNum";
            this.silverNum.Size = new System.Drawing.Size(60, 20);
            this.silverNum.TabIndex = 7;
            this.silverNum.ValueChanged += new System.EventHandler(this.input_ValueChanged);
            // 
            // brassNum
            // 
            this.brassNum.DecimalPlaces = 2;
            this.brassNum.Location = new System.Drawing.Point(258, 94);
            this.brassNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.brassNum.Name = "brassNum";
            this.brassNum.Size = new System.Drawing.Size(60, 20);
            this.brassNum.TabIndex = 8;
            this.brassNum.ValueChanged += new System.EventHandler(this.input_ValueChanged);
            // 
            // CoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 126);
            this.Controls.Add(this.brassNum);
            this.Controls.Add(this.silverNum);
            this.Controls.Add(this.goldNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CoinForm";
            this.Text = "Coins";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brassNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown goldNum;
        private System.Windows.Forms.NumericUpDown silverNum;
        private System.Windows.Forms.NumericUpDown brassNum;
    }
}