namespace quân_mã_đi_tuần_bản_chuẩn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vitrixuatphat = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_speed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình thuật toán quân mã đi tuần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "nhập ô xuất phát";
            // 
            // txt_vitrixuatphat
            // 
            this.txt_vitrixuatphat.Location = new System.Drawing.Point(194, 95);
            this.txt_vitrixuatphat.Name = "txt_vitrixuatphat";
            this.txt_vitrixuatphat.Size = new System.Drawing.Size(105, 20);
            this.txt_vitrixuatphat.TabIndex = 2;
            this.txt_vitrixuatphat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(28, 120);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(446, 32);
            this.btn_run.TabIndex = 3;
            this.btn_run.Text = "Chạy chương trình";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(28, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 379);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speed";
            // 
            // txt_speed
            // 
            this.txt_speed.Location = new System.Drawing.Point(383, 95);
            this.txt_speed.Name = "txt_speed";
            this.txt_speed.Size = new System.Drawing.Size(66, 20);
            this.txt_speed.TabIndex = 6;
            this.txt_speed.Text = "10";
            this.txt_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_speed.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 570);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_speed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.txt_vitrixuatphat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_vitrixuatphat;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_speed;
        private System.Windows.Forms.Label label4;
    }
}

