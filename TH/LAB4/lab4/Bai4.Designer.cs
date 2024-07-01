namespace lab4
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
            this.btnbrowser = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.txturl = new System.Windows.Forms.TextBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnreload = new System.Windows.Forms.Button();
            this.btndownload = new System.Windows.Forms.Button();
            this.btnviewsource = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbrowser
            // 
            this.btnbrowser.Location = new System.Drawing.Point(1092, 8);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(113, 34);
            this.btnbrowser.TabIndex = 1;
            this.btnbrowser.Text = "Browser";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(12, 8);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 34);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.webView21, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1524, 835);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(3, 3);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(75, 23);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // txturl
            // 
            this.txturl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txturl.Location = new System.Drawing.Point(406, 8);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(662, 34);
            this.txturl.TabIndex = 5;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(146, 8);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(100, 34);
            this.btnnext.TabIndex = 6;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(288, 8);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(100, 34);
            this.btnreload.TabIndex = 7;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btndownload
            // 
            this.btndownload.Location = new System.Drawing.Point(1223, 8);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(113, 34);
            this.btndownload.TabIndex = 8;
            this.btndownload.Text = "Download";
            this.btndownload.UseVisualStyleBackColor = true;
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // btnviewsource
            // 
            this.btnviewsource.Location = new System.Drawing.Point(1371, 8);
            this.btnviewsource.Name = "btnviewsource";
            this.btnviewsource.Size = new System.Drawing.Size(113, 34);
            this.btnviewsource.TabIndex = 9;
            this.btnviewsource.Text = "View Source";
            this.btnviewsource.UseVisualStyleBackColor = true;
            this.btnviewsource.Click += new System.EventHandler(this.btnviewsource_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 903);
            this.Controls.Add(this.btnviewsource);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnbrowser);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.Load += new System.EventHandler(this.Bai4_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnbrowser;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txturl;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.Button btnviewsource;
    }
}