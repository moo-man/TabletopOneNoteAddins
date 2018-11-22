namespace OneNote.WFRP
{
    partial class XpNeededForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XpNeededForm));
            this.currentAdvanceLabel = new System.Windows.Forms.Label();
            this.targetAdvanceLabel = new System.Windows.Forms.Label();
            this.charXpLabel = new System.Windows.Forms.Label();
            this.xpcostlabel = new System.Windows.Forms.Label();
            this.skillXplabel = new System.Windows.Forms.Label();
            this.charCost = new System.Windows.Forms.Label();
            this.skillCost = new System.Windows.Forms.Label();
            this.startNumeric = new System.Windows.Forms.NumericUpDown();
            this.targetNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.startNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // currentAdvanceLabel
            // 
            this.currentAdvanceLabel.AutoSize = true;
            this.currentAdvanceLabel.Location = new System.Drawing.Point(12, 9);
            this.currentAdvanceLabel.Name = "currentAdvanceLabel";
            this.currentAdvanceLabel.Size = new System.Drawing.Size(87, 13);
            this.currentAdvanceLabel.TabIndex = 0;
            this.currentAdvanceLabel.Text = "Current Advance";
            // 
            // targetAdvanceLabel
            // 
            this.targetAdvanceLabel.AutoSize = true;
            this.targetAdvanceLabel.Location = new System.Drawing.Point(114, 9);
            this.targetAdvanceLabel.Name = "targetAdvanceLabel";
            this.targetAdvanceLabel.Size = new System.Drawing.Size(84, 13);
            this.targetAdvanceLabel.TabIndex = 1;
            this.targetAdvanceLabel.Text = "Target Advance";
            // 
            // charXpLabel
            // 
            this.charXpLabel.AutoSize = true;
            this.charXpLabel.Location = new System.Drawing.Point(12, 83);
            this.charXpLabel.Name = "charXpLabel";
            this.charXpLabel.Size = new System.Drawing.Size(74, 13);
            this.charXpLabel.TabIndex = 2;
            this.charXpLabel.Text = "Characteristic:";
            // 
            // xpcostlabel
            // 
            this.xpcostlabel.AutoSize = true;
            this.xpcostlabel.Location = new System.Drawing.Point(79, 57);
            this.xpcostlabel.Name = "xpcostlabel";
            this.xpcostlabel.Size = new System.Drawing.Size(45, 13);
            this.xpcostlabel.TabIndex = 4;
            this.xpcostlabel.Text = "XP Cost";
            // 
            // skillXplabel
            // 
            this.skillXplabel.AutoSize = true;
            this.skillXplabel.Location = new System.Drawing.Point(122, 83);
            this.skillXplabel.Name = "skillXplabel";
            this.skillXplabel.Size = new System.Drawing.Size(29, 13);
            this.skillXplabel.TabIndex = 6;
            this.skillXplabel.Text = "Skill:";
            // 
            // charCost
            // 
            this.charCost.AutoSize = true;
            this.charCost.Location = new System.Drawing.Point(86, 83);
            this.charCost.Name = "charCost";
            this.charCost.Size = new System.Drawing.Size(13, 13);
            this.charCost.TabIndex = 7;
            this.charCost.Text = "0";
            // 
            // skillCost
            // 
            this.skillCost.AutoSize = true;
            this.skillCost.Location = new System.Drawing.Point(151, 83);
            this.skillCost.Name = "skillCost";
            this.skillCost.Size = new System.Drawing.Size(13, 13);
            this.skillCost.TabIndex = 8;
            this.skillCost.Text = "0";
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
            this.startNumeric.TabIndex = 9;
            this.startNumeric.ValueChanged += new System.EventHandler(this.Value_Changed);
            this.startNumeric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value_Changed);
            // 
            // targetNumeric
            // 
            this.targetNumeric.Location = new System.Drawing.Point(117, 25);
            this.targetNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.targetNumeric.Name = "targetNumeric";
            this.targetNumeric.Size = new System.Drawing.Size(74, 20);
            this.targetNumeric.TabIndex = 10;
            this.targetNumeric.ValueChanged += new System.EventHandler(this.Value_Changed);
            this.targetNumeric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value_Changed);
            // 
            // XpNeededForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 106);
            this.Controls.Add(this.targetNumeric);
            this.Controls.Add(this.startNumeric);
            this.Controls.Add(this.skillCost);
            this.Controls.Add(this.charCost);
            this.Controls.Add(this.skillXplabel);
            this.Controls.Add(this.xpcostlabel);
            this.Controls.Add(this.charXpLabel);
            this.Controls.Add(this.targetAdvanceLabel);
            this.Controls.Add(this.currentAdvanceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XpNeededForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XP Needed";
            ((System.ComponentModel.ISupportInitialize)(this.startNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentAdvanceLabel;
        private System.Windows.Forms.Label targetAdvanceLabel;
        private System.Windows.Forms.Label charXpLabel;
        private System.Windows.Forms.Label xpcostlabel;
        private System.Windows.Forms.Label skillXplabel;
        private System.Windows.Forms.Label charCost;
        private System.Windows.Forms.Label skillCost;
        private System.Windows.Forms.NumericUpDown startNumeric;
        private System.Windows.Forms.NumericUpDown targetNumeric;
    }
}