namespace lab2
{
    partial class Bai1
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
            this.content = new System.Windows.Forms.RichTextBox();
            this.rd = new System.Windows.Forms.Button();
            this.wr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.Location = new System.Drawing.Point(12, 12);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1173, 613);
            this.content.TabIndex = 0;
            this.content.Text = "";
            // 
            // rd
            // 
            this.rd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd.Location = new System.Drawing.Point(12, 631);
            this.rd.Name = "rd";
            this.rd.Size = new System.Drawing.Size(483, 90);
            this.rd.TabIndex = 1;
            this.rd.Text = "READ";
            this.rd.UseVisualStyleBackColor = true;
            this.rd.Click += new System.EventHandler(this.rd_Click);
            // 
            // wr
            // 
            this.wr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wr.Location = new System.Drawing.Point(717, 631);
            this.wr.Name = "wr";
            this.wr.Size = new System.Drawing.Size(468, 90);
            this.wr.TabIndex = 2;
            this.wr.Text = "WRITE";
            this.wr.UseVisualStyleBackColor = true;
            this.wr.Click += new System.EventHandler(this.wr_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 725);
            this.Controls.Add(this.wr);
            this.Controls.Add(this.rd);
            this.Controls.Add(this.content);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.Load += new System.EventHandler(this.Bai1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.Button rd;
        private System.Windows.Forms.Button wr;
    }
}