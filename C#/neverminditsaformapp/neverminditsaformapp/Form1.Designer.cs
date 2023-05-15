namespace neverminditsaformapp
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
            this.components = new System.ComponentModel.Container();
            this.fuelProgressBar = new System.Windows.Forms.ProgressBar();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.speedProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelMiles = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelGas = new System.Windows.Forms.Label();
            this.mpgTextBox = new System.Windows.Forms.TextBox();
            this.labelMPG = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hbPictureBox = new System.Windows.Forms.PictureBox();
            this.rtsPictureBox = new System.Windows.Forms.PictureBox();
            this.ltsPictureBox = new System.Windows.Forms.PictureBox();
            this.turnSignalTimer = new System.Windows.Forms.Timer(this.components);
            this.gasPedalLabel = new System.Windows.Forms.Label();
            this.brakePedalLabel = new System.Windows.Forms.Label();
            this.ltsRadioButton = new System.Windows.Forms.RadioButton();
            this.rtsRadioButton = new System.Windows.Forms.RadioButton();
            this.hbRadioButton = new System.Windows.Forms.RadioButton();
            this.tsoRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fuelProgressBar
            // 
            this.fuelProgressBar.Location = new System.Drawing.Point(193, 258);
            this.fuelProgressBar.Name = "fuelProgressBar";
            this.fuelProgressBar.Size = new System.Drawing.Size(197, 31);
            this.fuelProgressBar.TabIndex = 1;
            this.fuelProgressBar.Value = 100;
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(520, 267);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(100, 22);
            this.milesTextBox.TabIndex = 2;
            // 
            // speedProgressBar
            // 
            this.speedProgressBar.Location = new System.Drawing.Point(193, 156);
            this.speedProgressBar.Maximum = 131;
            this.speedProgressBar.Name = "speedProgressBar";
            this.speedProgressBar.Size = new System.Drawing.Size(197, 31);
            this.speedProgressBar.TabIndex = 6;
            // 
            // labelMiles
            // 
            this.labelMiles.AutoSize = true;
            this.labelMiles.Location = new System.Drawing.Point(549, 248);
            this.labelMiles.Name = "labelMiles";
            this.labelMiles.Size = new System.Drawing.Size(42, 16);
            this.labelMiles.TabIndex = 7;
            this.labelMiles.Text = "Miles:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(271, 137);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(40, 16);
            this.labelSpeed.TabIndex = 8;
            this.labelSpeed.Text = "MPH:";
            // 
            // labelGas
            // 
            this.labelGas.AutoSize = true;
            this.labelGas.Location = new System.Drawing.Point(273, 239);
            this.labelGas.Name = "labelGas";
            this.labelGas.Size = new System.Drawing.Size(36, 16);
            this.labelGas.TabIndex = 9;
            this.labelGas.Text = "Fuel:";
            // 
            // mpgTextBox
            // 
            this.mpgTextBox.Location = new System.Drawing.Point(520, 165);
            this.mpgTextBox.Name = "mpgTextBox";
            this.mpgTextBox.Size = new System.Drawing.Size(100, 22);
            this.mpgTextBox.TabIndex = 10;
            // 
            // labelMPG
            // 
            this.labelMPG.AutoSize = true;
            this.labelMPG.Location = new System.Drawing.Point(547, 146);
            this.labelMPG.Name = "labelMPG";
            this.labelMPG.Size = new System.Drawing.Size(40, 16);
            this.labelMPG.TabIndex = 11;
            this.labelMPG.Text = "MPG:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::neverminditsaformapp.Properties.Resources.gpbp;
            this.pictureBox1.Location = new System.Drawing.Point(193, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // hbPictureBox
            // 
            this.hbPictureBox.Image = global::neverminditsaformapp.Properties.Resources.highbeam;
            this.hbPictureBox.Location = new System.Drawing.Point(516, 12);
            this.hbPictureBox.Name = "hbPictureBox";
            this.hbPictureBox.Size = new System.Drawing.Size(104, 80);
            this.hbPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hbPictureBox.TabIndex = 5;
            this.hbPictureBox.TabStop = false;
            // 
            // rtsPictureBox
            // 
            this.rtsPictureBox.Image = global::neverminditsaformapp.Properties.Resources.rightArrow;
            this.rtsPictureBox.Location = new System.Drawing.Point(320, 12);
            this.rtsPictureBox.Name = "rtsPictureBox";
            this.rtsPictureBox.Size = new System.Drawing.Size(105, 80);
            this.rtsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rtsPictureBox.TabIndex = 4;
            this.rtsPictureBox.TabStop = false;
            // 
            // ltsPictureBox
            // 
            this.ltsPictureBox.Image = global::neverminditsaformapp.Properties.Resources.leftArrow;
            this.ltsPictureBox.Location = new System.Drawing.Point(193, 12);
            this.ltsPictureBox.Name = "ltsPictureBox";
            this.ltsPictureBox.Size = new System.Drawing.Size(105, 80);
            this.ltsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ltsPictureBox.TabIndex = 3;
            this.ltsPictureBox.TabStop = false;
            this.ltsPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // turnSignalTimer
            // 
            this.turnSignalTimer.Enabled = true;
            this.turnSignalTimer.Interval = 200;
            this.turnSignalTimer.Tick += new System.EventHandler(this.turnSignalTimer_Tick);
            // 
            // gasPedalLabel
            // 
            this.gasPedalLabel.Location = new System.Drawing.Point(351, 385);
            this.gasPedalLabel.Name = "gasPedalLabel";
            this.gasPedalLabel.Size = new System.Drawing.Size(39, 67);
            this.gasPedalLabel.TabIndex = 17;
            this.gasPedalLabel.Text = "Gas";
            this.gasPedalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gasPedalLabel.MouseEnter += new System.EventHandler(this.gasPedalLabel_MouseEnter);
            this.gasPedalLabel.MouseLeave += new System.EventHandler(this.gasPedalLabel_MouseLeave);
            // 
            // brakePedalLabel
            // 
            this.brakePedalLabel.Location = new System.Drawing.Point(221, 402);
            this.brakePedalLabel.Name = "brakePedalLabel";
            this.brakePedalLabel.Size = new System.Drawing.Size(101, 32);
            this.brakePedalLabel.TabIndex = 18;
            this.brakePedalLabel.Text = "Brake";
            this.brakePedalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ltsRadioButton
            // 
            this.ltsRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ltsRadioButton.Location = new System.Drawing.Point(503, 313);
            this.ltsRadioButton.Name = "ltsRadioButton";
            this.ltsRadioButton.Size = new System.Drawing.Size(139, 45);
            this.ltsRadioButton.TabIndex = 19;
            this.ltsRadioButton.TabStop = true;
            this.ltsRadioButton.Text = "Signal Left Turn";
            this.ltsRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ltsRadioButton.UseVisualStyleBackColor = true;
            this.ltsRadioButton.CheckedChanged += new System.EventHandler(this.ltsRadioButton_CheckedChanged);
            // 
            // rtsRadioButton
            // 
            this.rtsRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.rtsRadioButton.Location = new System.Drawing.Point(503, 364);
            this.rtsRadioButton.Name = "rtsRadioButton";
            this.rtsRadioButton.Size = new System.Drawing.Size(139, 45);
            this.rtsRadioButton.TabIndex = 20;
            this.rtsRadioButton.TabStop = true;
            this.rtsRadioButton.Text = "Signal Right Turn";
            this.rtsRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rtsRadioButton.UseVisualStyleBackColor = true;
            this.rtsRadioButton.CheckedChanged += new System.EventHandler(this.rtsRadioButton_CheckedChanged);
            // 
            // hbRadioButton
            // 
            this.hbRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.hbRadioButton.Location = new System.Drawing.Point(503, 415);
            this.hbRadioButton.Name = "hbRadioButton";
            this.hbRadioButton.Size = new System.Drawing.Size(139, 45);
            this.hbRadioButton.TabIndex = 21;
            this.hbRadioButton.TabStop = true;
            this.hbRadioButton.Text = "Turn on High Beams";
            this.hbRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hbRadioButton.UseVisualStyleBackColor = true;
            this.hbRadioButton.CheckedChanged += new System.EventHandler(this.hbRadioButton_CheckedChanged);
            // 
            // tsoRadioButton
            // 
            this.tsoRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.tsoRadioButton.Location = new System.Drawing.Point(648, 339);
            this.tsoRadioButton.Name = "tsoRadioButton";
            this.tsoRadioButton.Size = new System.Drawing.Size(139, 45);
            this.tsoRadioButton.TabIndex = 22;
            this.tsoRadioButton.TabStop = true;
            this.tsoRadioButton.Text = "Signals Off";
            this.tsoRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tsoRadioButton.UseVisualStyleBackColor = true;
            this.tsoRadioButton.CheckedChanged += new System.EventHandler(this.tsoRadioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.Location = new System.Drawing.Point(648, 415);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(139, 45);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Turn off High Beams";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 512);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tsoRadioButton);
            this.Controls.Add(this.hbRadioButton);
            this.Controls.Add(this.rtsRadioButton);
            this.Controls.Add(this.ltsRadioButton);
            this.Controls.Add(this.brakePedalLabel);
            this.Controls.Add(this.gasPedalLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMPG);
            this.Controls.Add(this.mpgTextBox);
            this.Controls.Add(this.labelGas);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelMiles);
            this.Controls.Add(this.speedProgressBar);
            this.Controls.Add(this.hbPictureBox);
            this.Controls.Add(this.rtsPictureBox);
            this.Controls.Add(this.ltsPictureBox);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.fuelProgressBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar fuelProgressBar;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.PictureBox ltsPictureBox;
        private System.Windows.Forms.PictureBox rtsPictureBox;
        private System.Windows.Forms.PictureBox hbPictureBox;
        private System.Windows.Forms.ProgressBar speedProgressBar;
        private System.Windows.Forms.Label labelMiles;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelGas;
        private System.Windows.Forms.TextBox mpgTextBox;
        private System.Windows.Forms.Label labelMPG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer turnSignalTimer;
        private System.Windows.Forms.Label gasPedalLabel;
        private System.Windows.Forms.Label brakePedalLabel;
        private System.Windows.Forms.RadioButton ltsRadioButton;
        private System.Windows.Forms.RadioButton rtsRadioButton;
        private System.Windows.Forms.RadioButton hbRadioButton;
        private System.Windows.Forms.RadioButton tsoRadioButton;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

