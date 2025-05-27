namespace SpamClassifierApp
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
            this.btnClassify = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblk = new System.Windows.Forms.Label();
            this.numK = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numK)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClassify
            // 
            this.btnClassify.AutoSize = true;
            this.btnClassify.BackColor = System.Drawing.Color.Crimson;
            this.btnClassify.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassify.Location = new System.Drawing.Point(457, 580);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(397, 55);
            this.btnClassify.TabIndex = 0;
            this.btnClassify.Text = "Classify";
            this.btnClassify.UseVisualStyleBackColor = false;
            this.btnClassify.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.RosyBrown;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtEmail.Location = new System.Drawing.Point(158, 232);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmail.Size = new System.Drawing.Size(494, 342);
            this.txtEmail.TabIndex = 1;
            // 
            // cmbAlgorithm
            // 
            this.cmbAlgorithm.BackColor = System.Drawing.Color.RosyBrown;
            this.cmbAlgorithm.FormattingEnabled = true;
            this.cmbAlgorithm.Location = new System.Drawing.Point(475, 202);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(177, 24);
            this.cmbAlgorithm.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.RosyBrown;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(662, 202);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(2, 31);
            this.lblResult.TabIndex = 3;
            // 
            // txtDetails
            // 
            this.txtDetails.BackColor = System.Drawing.Color.RosyBrown;
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(662, 236);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(494, 310);
            this.txtDetails.TabIndex = 4;
            // 
            // lblk
            // 
            this.lblk.AutoSize = true;
            this.lblk.BackColor = System.Drawing.Color.RosyBrown;
            this.lblk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblk.Location = new System.Drawing.Point(661, 552);
            this.lblk.Name = "lblk";
            this.lblk.Size = new System.Drawing.Size(103, 22);
            this.lblk.TabIndex = 5;
            this.lblk.Text = "Choose K:";
            // 
            // numK
            // 
            this.numK.BackColor = System.Drawing.Color.RosyBrown;
            this.numK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.numK.Location = new System.Drawing.Point(769, 552);
            this.numK.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numK.Name = "numK";
            this.numK.Size = new System.Drawing.Size(45, 21);
            this.numK.TabIndex = 6;
            this.numK.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(369, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 90);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email Classifier";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::SpamClassifierApp.Properties.Resources.spam_940521_scaled1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numK);
            this.Controls.Add(this.lblk);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmbAlgorithm);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnClassify);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Classifier";
            ((System.ComponentModel.ISupportInitialize)(this.numK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbAlgorithm;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblk;
        private System.Windows.Forms.NumericUpDown numK;
        private System.Windows.Forms.Label label1;
    }
}

