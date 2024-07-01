namespace ser
{
    partial class ser
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
            this.porttxt = new System.Windows.Forms.TextBox();
            this.receivetxt = new System.Windows.Forms.RichTextBox();
            this.listenbtn = new System.Windows.Forms.Button();
            this.sendbtn = new System.Windows.Forms.Button();
            this.sendtxt = new System.Windows.Forms.RichTextBox();
            this.clrbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // porttxt
            // 
            this.porttxt.Location = new System.Drawing.Point(539, 12);
            this.porttxt.Multiline = true;
            this.porttxt.Name = "porttxt";
            this.porttxt.Size = new System.Drawing.Size(223, 33);
            this.porttxt.TabIndex = 1;
            // 
            // receivetxt
            // 
            this.receivetxt.Location = new System.Drawing.Point(12, 127);
            this.receivetxt.Name = "receivetxt";
            this.receivetxt.Size = new System.Drawing.Size(363, 485);
            this.receivetxt.TabIndex = 2;
            this.receivetxt.Text = "";
            // 
            // listenbtn
            // 
            this.listenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listenbtn.Location = new System.Drawing.Point(12, 68);
            this.listenbtn.Name = "listenbtn";
            this.listenbtn.Size = new System.Drawing.Size(363, 53);
            this.listenbtn.TabIndex = 4;
            this.listenbtn.Text = "Listen";
            this.listenbtn.UseVisualStyleBackColor = true;
            this.listenbtn.Click += new System.EventHandler(this.listenbtn_Click);
            // 
            // sendbtn
            // 
            this.sendbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.Location = new System.Drawing.Point(805, 68);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(363, 53);
            this.sendbtn.TabIndex = 5;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // sendtxt
            // 
            this.sendtxt.Location = new System.Drawing.Point(805, 127);
            this.sendtxt.Name = "sendtxt";
            this.sendtxt.Size = new System.Drawing.Size(363, 485);
            this.sendtxt.TabIndex = 6;
            this.sendtxt.Text = "";
            // 
            // clrbtn
            // 
            this.clrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrbtn.Location = new System.Drawing.Point(454, 339);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(264, 53);
            this.clrbtn.TabIndex = 7;
            this.clrbtn.Text = "Exit";
            this.clrbtn.UseVisualStyleBackColor = true;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // ser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 624);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.sendtxt);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.listenbtn);
            this.Controls.Add(this.receivetxt);
            this.Controls.Add(this.porttxt);
            this.Controls.Add(this.label1);
            this.Name = "ser";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.ser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox porttxt;
        private System.Windows.Forms.RichTextBox receivetxt;
        private System.Windows.Forms.Button listenbtn;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.RichTextBox sendtxt;
        private System.Windows.Forms.Button clrbtn;
    }
}

