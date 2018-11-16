namespace ATM
{
    partial class frmForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForm1));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblToThe = new System.Windows.Forms.Label();
            this.lblRodgersBank = new System.Windows.Forms.Label();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.btnFindMe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblATM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(191, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(96, 18);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome . . .";
            // 
            // lblToThe
            // 
            this.lblToThe.AutoSize = true;
            this.lblToThe.Location = new System.Drawing.Point(218, 50);
            this.lblToThe.Name = "lblToThe";
            this.lblToThe.Size = new System.Drawing.Size(45, 13);
            this.lblToThe.TabIndex = 1;
            this.lblToThe.Text = "To The ";
            // 
            // lblRodgersBank
            // 
            this.lblRodgersBank.AutoSize = true;
            this.lblRodgersBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodgersBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblRodgersBank.Location = new System.Drawing.Point(148, 88);
            this.lblRodgersBank.Name = "lblRodgersBank";
            this.lblRodgersBank.Size = new System.Drawing.Size(194, 20);
            this.lblRodgersBank.TabIndex = 2;
            this.lblRodgersBank.Text = "Rodgers National Bank";
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.Location = new System.Drawing.Point(26, 312);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(457, 13);
            this.lblInstruction1.TabIndex = 3;
            this.lblInstruction1.Text = "Enter Your FIVE DIGIT Account Number in the Box Below. Then Press Find me.";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(78, 349);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(88, 20);
            this.txtAccountNumber.TabIndex = 4;
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.txtAccountNumber_TextChanged);
            // 
            // btnFindMe
            // 
            this.btnFindMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFindMe.Location = new System.Drawing.Point(347, 349);
            this.btnFindMe.Name = "btnFindMe";
            this.btnFindMe.Size = new System.Drawing.Size(75, 23);
            this.btnFindMe.TabIndex = 5;
            this.btnFindMe.Text = "Find Me";
            this.btnFindMe.UseVisualStyleBackColor = false;
            this.btnFindMe.Click += new System.EventHandler(this.btnFindMe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblATM
            // 
            this.lblATM.AutoSize = true;
            this.lblATM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATM.Location = new System.Drawing.Point(217, 123);
            this.lblATM.Name = "lblATM";
            this.lblATM.Size = new System.Drawing.Size(42, 20);
            this.lblATM.TabIndex = 7;
            this.lblATM.Text = "ATM";
            // 
            // frmForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 419);
            this.Controls.Add(this.lblATM);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFindMe);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblInstruction1);
            this.Controls.Add(this.lblRodgersBank);
            this.Controls.Add(this.lblToThe);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmForm1";
            this.Text = "frmForm1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblToThe;
        private System.Windows.Forms.Label lblRodgersBank;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnFindMe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblATM;
    }
}