namespace OneNote.WFRP
{
    partial class AdvancesPossibleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancesPossibleForm));
            this.XPNumeric = new System.Windows.Forms.NumericUpDown();
            this.startNumeric = new System.Windows.Forms.NumericUpDown();
            this.skillAdv = new System.Windows.Forms.Label();
            this.charAdv = new System.Windows.Forms.Label();
            this.skillAdvancesLabel = new System.Windows.Forms.Label();
            this.xpcostlabel = new System.Windows.Forms.Label();
            this.charAdvancesLabel = new System.Windows.Forms.Label();
            this.XpLabel = new System.Windows.Forms.Label();
            this.currentAdvanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.XPNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // XPNumeric
            // 
            this.XPNumeric.Location = new System.Drawing.Point(117, 25);
            this.XPNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.XPNumeric.Name = "XPNumeric";
            this.XPNumeric.Size = new System.Drawing.Size(74, 20);
            this.XPNumeric.TabIndex = 19;
            this.XPNumeric.ValueChanged += new System.EventHandler(this.Value_Changed);
            this.XPNumeric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value_Changed);
            // 
            // startNumeric
            // 
            this.startNumeric.Location = new System.Drawing.Point(15, 25);
            this.startNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.startNumeric.Name = "startNumeric";
            this.startNumeric.Size = new System.Drawing.Size(74, 20);
            this.startNumeric.TabIndex = 18;
            this.startNumeric.ValueChanged += new System.EventHandler(this.Value_Changed);
            this.startNumeric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value_Changed);
            // 
            // skillAdv
            // 
            this.skillAdv.AutoSize = true;
            this.skillAdv.Location = new System.Drawing.Point(151, 83);
            this.skillAdv.Name = "skillAdv";
            this.skillAdv.Size = new System.Drawing.Size(13, 13);
            this.skillAdv.TabIndex = 17;
            this.skillAdv.Text = "0";
            // 
            // charAdv
            // 
            this.charAdv.AutoSize = true;
            this.charAdv.Location = new System.Drawing.Point(86, 83);
            this.charAdv.Name = "charAdv";
            this.charAdv.Size = new System.Drawing.Size(13, 13);
            this.charAdv.TabIndex = 16;
            this.charAdv.Text = "0";
            // 
            // skillAdvancesLabel
            // 
            this.skillAdvancesLabel.AutoSize = true;
            this.skillAdvancesLabel.Location = new System.Drawing.Point(122, 83);
            this.skillAdvancesLabel.Name = "skillAdvancesLabel";
            this.skillAdvancesLabel.Size = new System.Drawing.Size(29, 13);
            this.skillAdvancesLabel.TabIndex = 15;
            this.skillAdvancesLabel.Text = "Skill:";
            // 
            // xpcostlabel
            // 
            this.xpcostlabel.AutoSize = true;
            this.xpcostlabel.Location = new System.Drawing.Point(50, 58);
            this.xpcostlabel.Name = "xpcostlabel";
            this.xpcostlabel.Size = new System.Drawing.Size(101, 13);
            this.xpcostlabel.TabIndex = 14;
            this.xpcostlabel.Text = "Advances Available";
            // 
            // charAdvancesLabel
            // 
            this.charAdvancesLabel.AutoSize = true;
            this.charAdvancesLabel.Location = new System.Drawing.Point(12, 83);
            this.charAdvancesLabel.Name = "charAdvancesLabel";
            this.charAdvancesLabel.Size = new System.Drawing.Size(74, 13);
            this.charAdvancesLabel.TabIndex = 13;
            this.charAdvancesLabel.Text = "Characteristic:";
            // 
            // XpLabel
            // 
            this.XpLabel.AutoSize = true;
            this.XpLabel.Location = new System.Drawing.Point(143, 9);
            this.XpLabel.Name = "XpLabel";
            this.XpLabel.Size = new System.Drawing.Size(21, 13);
            this.XpLabel.TabIndex = 12;
            this.XpLabel.Text = "XP";
            // 
            // currentAdvanceLabel
            // 
            this.currentAdvanceLabel.AutoSize = true;
            this.currentAdvanceLabel.Location = new System.Drawing.Point(12, 9);
            this.currentAdvanceLabel.Name = "currentAdvanceLabel";
            this.currentAdvanceLabel.Size = new System.Drawing.Size(87, 13);
            this.currentAdvanceLabel.TabIndex = 11;
            this.currentAdvanceLabel.Text = "Current Advance";
            // 
            // AdvancesPossibleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 106);
            this.Controls.Add(this.XPNumeric);
            this.Controls.Add(this.startNumeric);
            this.Controls.Add(this.skillAdv);
            this.Controls.Add(this.charAdv);
            this.Controls.Add(this.skillAdvancesLabel);
            this.Controls.Add(this.xpcostlabel);
            this.Controls.Add(this.charAdvancesLabel);
            this.Controls.Add(this.XpLabel);
            this.Controls.Add(this.currentAdvanceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancesPossibleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Advances";
            this.TopMost = true;
            this.Leave += new System.EventHandler(this.AdvancesPossibleForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.XPNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown XPNumeric;
        private System.Windows.Forms.NumericUpDown startNumeric;
        private System.Windows.Forms.Label skillAdv;
        private System.Windows.Forms.Label charAdv;
        private System.Windows.Forms.Label skillAdvancesLabel;
        private System.Windows.Forms.Label xpcostlabel;
        private System.Windows.Forms.Label charAdvancesLabel;
        private System.Windows.Forms.Label XpLabel;
        private System.Windows.Forms.Label currentAdvanceLabel;
    }
}