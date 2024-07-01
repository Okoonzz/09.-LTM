namespace lab2
{
    partial class Bai3
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
            this.readfl = new System.Windows.Forms.Button();
            this.cal = new System.Windows.Forms.Button();
            this.writefl = new System.Windows.Forms.Button();
            this.contentread = new System.Windows.Forms.RichTextBox();
            this.contentwrite = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // readfl
            // 
            this.readfl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readfl.Location = new System.Drawing.Point(13, 38);
            this.readfl.Name = "readfl";
            this.readfl.Size = new System.Drawing.Size(297, 85);
            this.readfl.TabIndex = 0;
            this.readfl.Text = "Read";
            this.readfl.UseVisualStyleBackColor = true;
            this.readfl.Click += new System.EventHandler(this.readfl_Click);
            // 
            // cal
            // 
            this.cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal.Location = new System.Drawing.Point(472, 38);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(248, 85);
            this.cal.TabIndex = 1;
            this.cal.Text = "Calculate";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // writefl
            // 
            this.writefl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writefl.Location = new System.Drawing.Point(883, 38);
            this.writefl.Name = "writefl";
            this.writefl.Size = new System.Drawing.Size(297, 85);
            this.writefl.TabIndex = 2;
            this.writefl.Text = "Write";
            this.writefl.UseVisualStyleBackColor = true;
            this.writefl.Click += new System.EventHandler(this.writefl_Click);
            // 
            // contentread
            // 
            this.contentread.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentread.Location = new System.Drawing.Point(13, 129);
            this.contentread.Name = "contentread";
            this.contentread.Size = new System.Drawing.Size(461, 555);
            this.contentread.TabIndex = 3;
            this.contentread.Text = "";
            // 
            // contentwrite
            // 
            this.contentwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentwrite.Location = new System.Drawing.Point(719, 129);
            this.contentwrite.Name = "contentwrite";
            this.contentwrite.Size = new System.Drawing.Size(461, 555);
            this.contentwrite.TabIndex = 4;
            this.contentwrite.Text = "";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 696);
            this.Controls.Add(this.contentwrite);
            this.Controls.Add(this.contentread);
            this.Controls.Add(this.writefl);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.readfl);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readfl;
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.Button writefl;
        private System.Windows.Forms.RichTextBox contentread;
        private System.Windows.Forms.RichTextBox contentwrite;
    }
}