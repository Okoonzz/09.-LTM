namespace Calcul
{
    partial class Form5
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
            this.pts = new System.Windows.Forms.TextBox();
            this.appear = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtbbtn = new System.Windows.Forms.TextBox();
            this.maxbtn = new System.Windows.Forms.TextBox();
            this.passbtn = new System.Windows.Forms.TextBox();
            this.xeploaibtn = new System.Windows.Forms.TextBox();
            this.minbtn = new System.Windows.Forms.TextBox();
            this.failbtn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm quản lí điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách điểm";
            // 
            // pts
            // 
            this.pts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pts.Location = new System.Drawing.Point(316, 63);
            this.pts.Multiline = true;
            this.pts.Name = "pts";
            this.pts.Size = new System.Drawing.Size(837, 36);
            this.pts.TabIndex = 2;
            // 
            // appear
            // 
            this.appear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appear.Location = new System.Drawing.Point(939, 105);
            this.appear.Name = "appear";
            this.appear.Size = new System.Drawing.Size(104, 55);
            this.appear.TabIndex = 3;
            this.appear.Text = "Xuất";
            this.appear.UseVisualStyleBackColor = true;
            this.appear.Click += new System.EventHandler(this.appear_Click);
            // 
            // res
            // 
            this.res.BackColor = System.Drawing.SystemColors.Menu;
            this.res.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(6, 29);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(934, 176);
            this.res.TabIndex = 4;
            this.res.Text = "";
            this.res.TextChanged += new System.EventHandler(this.res_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Điểm trung bình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điểm cao nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số môn đậu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(752, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "Xếp loại học lực";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(752, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "Điểm thấp nhất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(752, 624);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 36);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số môn không đậu";
            // 
            // dtbbtn
            // 
            this.dtbbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.dtbbtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtbbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbbtn.Location = new System.Drawing.Point(316, 434);
            this.dtbbtn.Multiline = true;
            this.dtbbtn.Name = "dtbbtn";
            this.dtbbtn.Size = new System.Drawing.Size(104, 36);
            this.dtbbtn.TabIndex = 11;
            // 
            // maxbtn
            // 
            this.maxbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.maxbtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxbtn.Location = new System.Drawing.Point(316, 527);
            this.maxbtn.Multiline = true;
            this.maxbtn.Name = "maxbtn";
            this.maxbtn.Size = new System.Drawing.Size(104, 36);
            this.maxbtn.TabIndex = 12;
            this.maxbtn.TextChanged += new System.EventHandler(this.maxbtn_TextChanged);
            // 
            // passbtn
            // 
            this.passbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.passbtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbtn.Location = new System.Drawing.Point(316, 630);
            this.passbtn.Multiline = true;
            this.passbtn.Name = "passbtn";
            this.passbtn.Size = new System.Drawing.Size(104, 36);
            this.passbtn.TabIndex = 13;
            // 
            // xeploaibtn
            // 
            this.xeploaibtn.BackColor = System.Drawing.SystemColors.Menu;
            this.xeploaibtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xeploaibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xeploaibtn.Location = new System.Drawing.Point(1020, 434);
            this.xeploaibtn.Multiline = true;
            this.xeploaibtn.Name = "xeploaibtn";
            this.xeploaibtn.Size = new System.Drawing.Size(133, 36);
            this.xeploaibtn.TabIndex = 14;
            // 
            // minbtn
            // 
            this.minbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.minbtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minbtn.Location = new System.Drawing.Point(1049, 524);
            this.minbtn.Multiline = true;
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(104, 36);
            this.minbtn.TabIndex = 15;
            this.minbtn.TextChanged += new System.EventHandler(this.minbtn_TextChanged);
            // 
            // failbtn
            // 
            this.failbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.failbtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.failbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failbtn.Location = new System.Drawing.Point(1049, 630);
            this.failbtn.Multiline = true;
            this.failbtn.Name = "failbtn";
            this.failbtn.Size = new System.Drawing.Size(104, 36);
            this.failbtn.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.res);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(97, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 211);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học và điểm";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1058, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 55);
            this.button1.TabIndex = 18;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.failbtn);
            this.Controls.Add(this.minbtn);
            this.Controls.Add(this.xeploaibtn);
            this.Controls.Add(this.passbtn);
            this.Controls.Add(this.maxbtn);
            this.Controls.Add(this.dtbbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.appear);
            this.Controls.Add(this.pts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Informatiom";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pts;
        private System.Windows.Forms.Button appear;
        private System.Windows.Forms.RichTextBox res;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dtbbtn;
        private System.Windows.Forms.TextBox maxbtn;
        private System.Windows.Forms.TextBox passbtn;
        private System.Windows.Forms.TextBox xeploaibtn;
        private System.Windows.Forms.TextBox minbtn;
        private System.Windows.Forms.TextBox failbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}