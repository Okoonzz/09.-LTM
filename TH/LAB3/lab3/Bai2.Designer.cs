namespace lab3
{
    partial class Bai2
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
            this.listenbtn = new System.Windows.Forms.Button();
            this.servertxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listenbtn
            // 
            this.listenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listenbtn.Location = new System.Drawing.Point(507, 27);
            this.listenbtn.Name = "listenbtn";
            this.listenbtn.Size = new System.Drawing.Size(194, 49);
            this.listenbtn.TabIndex = 0;
            this.listenbtn.Text = "Listen";
            this.listenbtn.UseVisualStyleBackColor = true;
            this.listenbtn.Click += new System.EventHandler(this.listenbtn_Click);
            // 
            // servertxt
            // 
            this.servertxt.Location = new System.Drawing.Point(13, 101);
            this.servertxt.Name = "servertxt";
            this.servertxt.Size = new System.Drawing.Size(688, 522);
            this.servertxt.TabIndex = 1;
            this.servertxt.Text = "";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 635);
            this.Controls.Add(this.servertxt);
            this.Controls.Add(this.listenbtn);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listenbtn;
        private System.Windows.Forms.RichTextBox servertxt;
    }
}