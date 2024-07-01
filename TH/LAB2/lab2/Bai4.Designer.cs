namespace lab2
{
    partial class Bai4
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
            this.enterdata = new System.Windows.Forms.Button();
            this.savetoexcel = new System.Windows.Forms.Button();
            this.displayinformation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // enterdata
            // 
            this.enterdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterdata.Location = new System.Drawing.Point(12, 90);
            this.enterdata.Name = "enterdata";
            this.enterdata.Size = new System.Drawing.Size(257, 96);
            this.enterdata.TabIndex = 1;
            this.enterdata.Text = "Enter Data";
            this.enterdata.UseVisualStyleBackColor = true;
            this.enterdata.Click += new System.EventHandler(this.button1_Click);
            // 
            // savetoexcel
            // 
            this.savetoexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savetoexcel.Location = new System.Drawing.Point(12, 254);
            this.savetoexcel.Name = "savetoexcel";
            this.savetoexcel.Size = new System.Drawing.Size(257, 96);
            this.savetoexcel.TabIndex = 2;
            this.savetoexcel.Text = "Save to Excel";
            this.savetoexcel.UseVisualStyleBackColor = true;
            this.savetoexcel.Click += new System.EventHandler(this.button2_Click);
            // 
            // displayinformation
            // 
            this.displayinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayinformation.Location = new System.Drawing.Point(12, 425);
            this.displayinformation.Name = "displayinformation";
            this.displayinformation.Size = new System.Drawing.Size(257, 96);
            this.displayinformation.TabIndex = 3;
            this.displayinformation.Text = "Display information";
            this.displayinformation.UseVisualStyleBackColor = true;
            this.displayinformation.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(302, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(865, 578);
            this.dataGridView1.TabIndex = 4;
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 602);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.displayinformation);
            this.Controls.Add(this.savetoexcel);
            this.Controls.Add(this.enterdata);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.Load += new System.EventHandler(this.Bai4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button enterdata;
        private System.Windows.Forms.Button savetoexcel;
        private System.Windows.Forms.Button displayinformation;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}