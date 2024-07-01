namespace Calcul
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
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Fi = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Ex = new System.Windows.Forms.Button();
            this.minn = new System.Windows.Forms.TextBox();
            this.maxx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm số lớn nhất, nhỏ nhất";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(124, 38);
            this.num1.Multiline = true;
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(146, 29);
            this.num1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số thứ 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số thứ 2";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(445, 38);
            this.num2.Multiline = true;
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(146, 29);
            this.num2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(621, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số thứ 3";
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(738, 38);
            this.num3.Multiline = true;
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(146, 29);
            this.num3.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.num1);
            this.groupBox1.Controls.Add(this.num3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 104);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các giá trị";
            // 
            // Fi
            // 
            this.Fi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fi.Location = new System.Drawing.Point(366, 302);
            this.Fi.Name = "Fi";
            this.Fi.Size = new System.Drawing.Size(158, 76);
            this.Fi.TabIndex = 10;
            this.Fi.Text = "Tìm";
            this.Fi.UseVisualStyleBackColor = true;
            this.Fi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Del
            // 
            this.Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del.Location = new System.Drawing.Point(63, 302);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(158, 76);
            this.Del.TabIndex = 11;
            this.Del.Text = "Xóa";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ex
            // 
            this.Ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ex.Location = new System.Drawing.Point(686, 302);
            this.Ex.Name = "Ex";
            this.Ex.Size = new System.Drawing.Size(158, 76);
            this.Ex.TabIndex = 12;
            this.Ex.Text = "Thoát";
            this.Ex.UseVisualStyleBackColor = true;
            this.Ex.Click += new System.EventHandler(this.button3_Click);
            // 
            // minn
            // 
            this.minn.Location = new System.Drawing.Point(174, 36);
            this.minn.Multiline = true;
            this.minn.Name = "minn";
            this.minn.Size = new System.Drawing.Size(195, 36);
            this.minn.TabIndex = 13;
            // 
            // maxx
            // 
            this.maxx.Location = new System.Drawing.Point(637, 36);
            this.maxx.Multiline = true;
            this.maxx.Name = "maxx";
            this.maxx.Size = new System.Drawing.Size(195, 36);
            this.maxx.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số bé nhất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(489, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số lớn nhất";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxx);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.minn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 99);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Ex);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Fi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Findnum";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Fi;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Ex;
        private System.Windows.Forms.TextBox minn;
        private System.Windows.Forms.TextBox maxx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}