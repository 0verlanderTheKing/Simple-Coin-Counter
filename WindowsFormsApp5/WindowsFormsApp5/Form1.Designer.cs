namespace WindowsFormsApp5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tenCentButton = new System.Windows.Forms.Button();
            this.fiveCentButton = new System.Windows.Forms.Button();
            this.twentyfiveCentButton = new System.Windows.Forms.Button();
            this.fiftyCentButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tenCentButton
            // 
            this.tenCentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tenCentButton.BackgroundImage")));
            this.tenCentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tenCentButton.Location = new System.Drawing.Point(37, 28);
            this.tenCentButton.Name = "tenCentButton";
            this.tenCentButton.Size = new System.Drawing.Size(87, 90);
            this.tenCentButton.TabIndex = 0;
            this.tenCentButton.UseVisualStyleBackColor = true;
            this.tenCentButton.Click += new System.EventHandler(this.tenCentButton_Click);
            // 
            // fiveCentButton
            // 
            this.fiveCentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fiveCentButton.BackgroundImage")));
            this.fiveCentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fiveCentButton.Location = new System.Drawing.Point(37, 124);
            this.fiveCentButton.Name = "fiveCentButton";
            this.fiveCentButton.Size = new System.Drawing.Size(87, 85);
            this.fiveCentButton.TabIndex = 1;
            this.fiveCentButton.UseVisualStyleBackColor = true;
            this.fiveCentButton.Click += new System.EventHandler(this.fiveCentButton_Click);
            // 
            // twentyfiveCentButton
            // 
            this.twentyfiveCentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("twentyfiveCentButton.BackgroundImage")));
            this.twentyfiveCentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.twentyfiveCentButton.Location = new System.Drawing.Point(37, 226);
            this.twentyfiveCentButton.Name = "twentyfiveCentButton";
            this.twentyfiveCentButton.Size = new System.Drawing.Size(87, 86);
            this.twentyfiveCentButton.TabIndex = 2;
            this.twentyfiveCentButton.UseVisualStyleBackColor = true;
            this.twentyfiveCentButton.Click += new System.EventHandler(this.twentyfiveCentButton_Click);
            // 
            // fiftyCentButton
            // 
            this.fiftyCentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fiftyCentButton.BackgroundImage")));
            this.fiftyCentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fiftyCentButton.Location = new System.Drawing.Point(37, 319);
            this.fiftyCentButton.Name = "fiftyCentButton";
            this.fiftyCentButton.Size = new System.Drawing.Size(87, 88);
            this.fiftyCentButton.TabIndex = 3;
            this.fiftyCentButton.UseVisualStyleBackColor = true;
            this.fiftyCentButton.Click += new System.EventHandler(this.fiftyCentButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(181, 115);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(181, 197);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Reset";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.fiftyCentButton);
            this.Controls.Add(this.twentyfiveCentButton);
            this.Controls.Add(this.fiveCentButton);
            this.Controls.Add(this.tenCentButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tenCentButton;
        private System.Windows.Forms.Button fiveCentButton;
        private System.Windows.Forms.Button twentyfiveCentButton;
        private System.Windows.Forms.Button fiftyCentButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

