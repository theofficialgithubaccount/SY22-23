namespace csharpwindowsform
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
            this.buyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.amtTextBox = new System.Windows.Forms.TextBox();
            this.amtLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.expTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.ccTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.expLabel = new System.Windows.Forms.Label();
            this.ccLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.feeLabel = new System.Windows.Forms.Label();
            this.feeTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(115, 354);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 0;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(196, 354);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.feeTextBox);
            this.panel1.Controls.Add(this.feeLabel);
            this.panel1.Controls.Add(this.amtTextBox);
            this.panel1.Controls.Add(this.amtLabel);
            this.panel1.Controls.Add(this.zipTextBox);
            this.panel1.Controls.Add(this.buyButton);
            this.panel1.Controls.Add(this.expTextBox);
            this.panel1.Controls.Add(this.zipLabel);
            this.panel1.Controls.Add(this.ccTextBox);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.expLabel);
            this.panel1.Controls.Add(this.ccLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(235, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 380);
            this.panel1.TabIndex = 2;
            // 
            // amtTextBox
            // 
            this.amtTextBox.Location = new System.Drawing.Point(171, 173);
            this.amtTextBox.Name = "amtTextBox";
            this.amtTextBox.Size = new System.Drawing.Size(100, 22);
            this.amtTextBox.TabIndex = 7;
            // 
            // amtLabel
            // 
            this.amtLabel.AutoSize = true;
            this.amtLabel.Location = new System.Drawing.Point(22, 176);
            this.amtLabel.Name = "amtLabel";
            this.amtLabel.Size = new System.Drawing.Size(55, 16);
            this.amtLabel.TabIndex = 7;
            this.amtLabel.Text = "Amount:";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(171, 135);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 22);
            this.zipTextBox.TabIndex = 6;
            // 
            // expTextBox
            // 
            this.expTextBox.Location = new System.Drawing.Point(171, 97);
            this.expTextBox.Name = "expTextBox";
            this.expTextBox.Size = new System.Drawing.Size(100, 22);
            this.expTextBox.TabIndex = 5;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(22, 138);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(30, 16);
            this.zipLabel.TabIndex = 6;
            this.zipLabel.Text = "ZIP:";
            // 
            // ccTextBox
            // 
            this.ccTextBox.Location = new System.Drawing.Point(171, 59);
            this.ccTextBox.Name = "ccTextBox";
            this.ccTextBox.Size = new System.Drawing.Size(100, 22);
            this.ccTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(171, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.Location = new System.Drawing.Point(22, 100);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(68, 16);
            this.expLabel.TabIndex = 5;
            this.expLabel.Text = "Exp. Date:";
            // 
            // ccLabel
            // 
            this.ccLabel.AutoSize = true;
            this.ccLabel.Location = new System.Drawing.Point(22, 62);
            this.ccLabel.Name = "ccLabel";
            this.ccLabel.Size = new System.Drawing.Size(35, 16);
            this.ccLabel.TabIndex = 4;
            this.ccLabel.Text = "CC#:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 16);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(26, 230);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(34, 16);
            this.feeLabel.TabIndex = 3;
            this.feeLabel.Text = "Fee:";
            this.feeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // feeTextBox
            // 
            this.feeTextBox.Location = new System.Drawing.Point(171, 230);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.ReadOnly = true;
            this.feeTextBox.Size = new System.Drawing.Size(100, 22);
            this.feeTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox amtTextBox;
        private System.Windows.Forms.Label amtLabel;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox expTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox ccTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label expLabel;
        private System.Windows.Forms.Label ccLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox feeTextBox;
        private System.Windows.Forms.Label feeLabel;
    }
}

