namespace ReadFile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChooseFile = new Button();
            ctpath = new RichTextBox();
            SuspendLayout();
            // 
            // ChooseFile
            // 
            ChooseFile.Location = new Point(52, 256);
            ChooseFile.Name = "ChooseFile";
            ChooseFile.Size = new Size(241, 98);
            ChooseFile.TabIndex = 0;
            ChooseFile.Text = "ChooseFile";
            ChooseFile.UseVisualStyleBackColor = true;
            ChooseFile.Click += ChooseFile_Click;
            // 
            // ctpath
            // 
            ctpath.Location = new Point(309, 23);
            ctpath.Name = "ctpath";
            ctpath.Size = new Size(833, 680);
            ctpath.TabIndex = 1;
            ctpath.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 715);
            Controls.Add(ctpath);
            Controls.Add(ChooseFile);
            Name = "Form1";
            Text = "22520167";
            ResumeLayout(false);
        }

        #endregion

        private Button ChooseFile;
        private RichTextBox ctpath;
    }
}