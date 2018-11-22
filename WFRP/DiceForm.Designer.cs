namespace OneNote.WFRP
{
    partial class DiceForm
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
            this.roll100Button = new System.Windows.Forms.Button();
            this.roll10button = new System.Windows.Forms.Button();
            this.d10label = new System.Windows.Forms.Label();
            this.d100label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roll100Button
            // 
            this.roll100Button.Location = new System.Drawing.Point(12, 12);
            this.roll100Button.Name = "roll100Button";
            this.roll100Button.Size = new System.Drawing.Size(58, 23);
            this.roll100Button.TabIndex = 0;
            this.roll100Button.Text = "d100";
            this.roll100Button.UseVisualStyleBackColor = true;
            this.roll100Button.Click += new System.EventHandler(this.roll100Button_Click);
            // 
            // roll10button
            // 
            this.roll10button.Location = new System.Drawing.Point(12, 51);
            this.roll10button.Name = "roll10button";
            this.roll10button.Size = new System.Drawing.Size(58, 23);
            this.roll10button.TabIndex = 1;
            this.roll10button.Text = "d10";
            this.roll10button.UseVisualStyleBackColor = true;
            this.roll10button.Click += new System.EventHandler(this.roll10button_Click);
            // 
            // d10label
            // 
            this.d10label.AutoSize = true;
            this.d10label.Location = new System.Drawing.Point(97, 56);
            this.d10label.Name = "d10label";
            this.d10label.Size = new System.Drawing.Size(0, 13);
            this.d10label.TabIndex = 2;
            // 
            // d100label
            // 
            this.d100label.AutoSize = true;
            this.d100label.Location = new System.Drawing.Point(97, 17);
            this.d100label.Name = "d100label";
            this.d100label.Size = new System.Drawing.Size(0, 13);
            this.d100label.TabIndex = 3;
            // 
            // DiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 86);
            this.Controls.Add(this.d100label);
            this.Controls.Add(this.d10label);
            this.Controls.Add(this.roll10button);
            this.Controls.Add(this.roll100Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiceForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button roll100Button;
        private System.Windows.Forms.Button roll10button;
        private System.Windows.Forms.Label d10label;
        private System.Windows.Forms.Label d100label;
    }
}