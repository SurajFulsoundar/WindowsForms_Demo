namespace WindowsForms_Demo
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
            this.btncancle = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.Crimson;
            this.btncancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.Location = new System.Drawing.Point(402, 299);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(158, 38);
            this.btncancle.TabIndex = 0;
            this.btncancle.Text = "Cancle";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Chartreuse;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogin.Location = new System.Drawing.Point(165, 299);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(149, 38);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(64, 166);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(91, 20);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(64, 76);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(103, 20);
            this.lblusername.TabIndex = 3;
            this.lblusername.Text = "User Name";
            // 
            // txtpassword
            // 
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(250, 166);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(167, 27);
            this.txtpassword.TabIndex = 4;
            // 
            // txtusername
            // 
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(250, 73);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(167, 27);
            this.txtusername.TabIndex = 5;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btncancle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
    }
}

