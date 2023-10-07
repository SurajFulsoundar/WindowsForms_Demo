namespace WindowsForms_Demo
{
    partial class Form2
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
            this.btndisplay = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.lblgrosssalary = new System.Windows.Forms.Label();
            this.lblempid = new System.Windows.Forms.Label();
            this.lblpf = new System.Windows.Forms.Label();
            this.lblhra = new System.Windows.Forms.Label();
            this.lblda = new System.Windows.Forms.Label();
            this.lblempname = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblta = new System.Windows.Forms.Label();
            this.lblbasicsalary = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtgrosssalary = new System.Windows.Forms.TextBox();
            this.txtpf = new System.Windows.Forms.TextBox();
            this.txtda = new System.Windows.Forms.TextBox();
            this.txtta = new System.Windows.Forms.TextBox();
            this.txthra = new System.Windows.Forms.TextBox();
            this.txtbasicsalary = new System.Windows.Forms.TextBox();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.cmbdepartment = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndisplay
            // 
            this.btndisplay.BackColor = System.Drawing.Color.Red;
            this.btndisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.Location = new System.Drawing.Point(819, 470);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(190, 48);
            this.btndisplay.TabIndex = 0;
            this.btndisplay.Text = "Display";
            this.btndisplay.UseVisualStyleBackColor = false;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.YellowGreen;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(557, 473);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(190, 48);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(525, 129);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(70, 20);
            this.lblmsg.TabIndex = 2;
            this.lblmsg.Text = "lbl msg";
            // 
            // lblgrosssalary
            // 
            this.lblgrosssalary.AutoSize = true;
            this.lblgrosssalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrosssalary.Location = new System.Drawing.Point(42, 558);
            this.lblgrosssalary.Name = "lblgrosssalary";
            this.lblgrosssalary.Size = new System.Drawing.Size(119, 20);
            this.lblgrosssalary.TabIndex = 3;
            this.lblgrosssalary.Text = "Gross Salary";
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempid.Location = new System.Drawing.Point(44, 12);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(67, 20);
            this.lblempid.TabIndex = 4;
            this.lblempid.Text = "Emp Id";
            // 
            // lblpf
            // 
            this.lblpf.AutoSize = true;
            this.lblpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpf.Location = new System.Drawing.Point(44, 489);
            this.lblpf.Name = "lblpf";
            this.lblpf.Size = new System.Drawing.Size(32, 20);
            this.lblpf.TabIndex = 5;
            this.lblpf.Text = "PF";
            // 
            // lblhra
            // 
            this.lblhra.AutoSize = true;
            this.lblhra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhra.Location = new System.Drawing.Point(44, 268);
            this.lblhra.Name = "lblhra";
            this.lblhra.Size = new System.Drawing.Size(48, 20);
            this.lblhra.TabIndex = 6;
            this.lblhra.Text = "HRA";
            // 
            // lblda
            // 
            this.lblda.AutoSize = true;
            this.lblda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblda.Location = new System.Drawing.Point(44, 410);
            this.lblda.Name = "lblda";
            this.lblda.Size = new System.Drawing.Size(35, 20);
            this.lblda.TabIndex = 7;
            this.lblda.Text = "DA";
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempname.Location = new System.Drawing.Point(44, 65);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(100, 20);
            this.lblempname.TabIndex = 8;
            this.lblempname.Text = "Emp Name";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(44, 129);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(107, 20);
            this.lbldepartment.TabIndex = 9;
            this.lbldepartment.Text = "Department";
            // 
            // lblta
            // 
            this.lblta.AutoSize = true;
            this.lblta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblta.Location = new System.Drawing.Point(44, 343);
            this.lblta.Name = "lblta";
            this.lblta.Size = new System.Drawing.Size(32, 20);
            this.lblta.TabIndex = 10;
            this.lblta.Text = "TA";
            // 
            // lblbasicsalary
            // 
            this.lblbasicsalary.AutoSize = true;
            this.lblbasicsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbasicsalary.Location = new System.Drawing.Point(44, 197);
            this.lblbasicsalary.Name = "lblbasicsalary";
            this.lblbasicsalary.Size = new System.Drawing.Size(116, 20);
            this.lblbasicsalary.TabIndex = 11;
            this.lblbasicsalary.Text = "Basic Salary";
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(224, 6);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(162, 22);
            this.txtempid.TabIndex = 13;
            // 
            // txtgrosssalary
            // 
            this.txtgrosssalary.Location = new System.Drawing.Point(224, 555);
            this.txtgrosssalary.Name = "txtgrosssalary";
            this.txtgrosssalary.Size = new System.Drawing.Size(162, 22);
            this.txtgrosssalary.TabIndex = 14;
            // 
            // txtpf
            // 
            this.txtpf.Location = new System.Drawing.Point(224, 483);
            this.txtpf.Name = "txtpf";
            this.txtpf.Size = new System.Drawing.Size(162, 22);
            this.txtpf.TabIndex = 15;
            // 
            // txtda
            // 
            this.txtda.Location = new System.Drawing.Point(224, 407);
            this.txtda.Name = "txtda";
            this.txtda.Size = new System.Drawing.Size(162, 22);
            this.txtda.TabIndex = 16;
            // 
            // txtta
            // 
            this.txtta.Location = new System.Drawing.Point(224, 340);
            this.txtta.Name = "txtta";
            this.txtta.Size = new System.Drawing.Size(162, 22);
            this.txtta.TabIndex = 17;
            // 
            // txthra
            // 
            this.txthra.Location = new System.Drawing.Point(224, 262);
            this.txthra.Name = "txthra";
            this.txthra.Size = new System.Drawing.Size(162, 22);
            this.txthra.TabIndex = 18;
            // 
            // txtbasicsalary
            // 
            this.txtbasicsalary.Location = new System.Drawing.Point(224, 191);
            this.txtbasicsalary.Name = "txtbasicsalary";
            this.txtbasicsalary.Size = new System.Drawing.Size(162, 22);
            this.txtbasicsalary.TabIndex = 19;
            // 
            // txtempname
            // 
            this.txtempname.Location = new System.Drawing.Point(224, 59);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(162, 22);
            this.txtempname.TabIndex = 21;
            // 
            // cmbdepartment
            // 
            this.cmbdepartment.FormattingEnabled = true;
            this.cmbdepartment.Location = new System.Drawing.Point(224, 121);
            this.cmbdepartment.Name = "cmbdepartment";
            this.cmbdepartment.Size = new System.Drawing.Size(162, 24);
            this.cmbdepartment.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1015, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 44);
            this.button3.TabIndex = 23;
            this.button3.Text = "Exit -->";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1197, 614);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbdepartment);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.txtbasicsalary);
            this.Controls.Add(this.txthra);
            this.Controls.Add(this.txtta);
            this.Controls.Add(this.txtda);
            this.Controls.Add(this.txtpf);
            this.Controls.Add(this.txtgrosssalary);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.lblbasicsalary);
            this.Controls.Add(this.lblta);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.lblda);
            this.Controls.Add(this.lblhra);
            this.Controls.Add(this.lblpf);
            this.Controls.Add(this.lblempid);
            this.Controls.Add(this.lblgrosssalary);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btndisplay);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label lblgrosssalary;
        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.Label lblpf;
        private System.Windows.Forms.Label lblhra;
        private System.Windows.Forms.Label lblda;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblta;
        private System.Windows.Forms.Label lblbasicsalary;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.TextBox txtgrosssalary;
        private System.Windows.Forms.TextBox txtpf;
        private System.Windows.Forms.TextBox txtda;
        private System.Windows.Forms.TextBox txtta;
        private System.Windows.Forms.TextBox txthra;
        private System.Windows.Forms.TextBox txtbasicsalary;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.ComboBox cmbdepartment;
        private System.Windows.Forms.Button button3;
    }
}