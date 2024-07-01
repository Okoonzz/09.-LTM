namespace Calcul
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.del = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Ex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đọc số (0 đến 9)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đọc số";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(327, 162);
            this.num1.Multiline = true;
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(327, 31);
            this.num1.TabIndex = 3;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(327, 243);
            this.num2.Multiline = true;
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(327, 31);
            this.num2.TabIndex = 4;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(41, 342);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(171, 76);
            this.del.TabIndex = 5;
            this.del.Text = "Xóa";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.button1_Click);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(334, 342);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(171, 76);
            this.Read.TabIndex = 6;
            this.Read.Text = "Đọc";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Ex
            // 
            this.Ex.Location = new System.Drawing.Point(617, 342);
            this.Ex.Name = "Ex";
            this.Ex.Size = new System.Drawing.Size(171, 76);
            this.Ex.TabIndex = 7;
            this.Ex.Text = "Thoát";
            this.Ex.UseVisualStyleBackColor = true;
            this.Ex.Click += new System.EventHandler(this.Ex_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ex);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.del);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Readnum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Ex;
    }
}