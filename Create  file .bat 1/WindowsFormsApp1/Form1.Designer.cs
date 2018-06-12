namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnKIOSK = new System.Windows.Forms.Button();
            this.btnPEAQClient = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnmove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKIOSK
            // 
            this.btnKIOSK.Location = new System.Drawing.Point(52, 110);
            this.btnKIOSK.Name = "btnKIOSK";
            this.btnKIOSK.Size = new System.Drawing.Size(151, 42);
            this.btnKIOSK.TabIndex = 0;
            this.btnKIOSK.Text = "Create File KIOSK";
            this.btnKIOSK.UseVisualStyleBackColor = true;
            this.btnKIOSK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPEAQClient
            // 
            this.btnPEAQClient.Location = new System.Drawing.Point(52, 173);
            this.btnPEAQClient.Name = "btnPEAQClient";
            this.btnPEAQClient.Size = new System.Drawing.Size(151, 42);
            this.btnPEAQClient.TabIndex = 1;
            this.btnPEAQClient.Text = "Create File PEAQClient";
            this.btnPEAQClient.UseVisualStyleBackColor = true;
            this.btnPEAQClient.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(52, 47);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(151, 42);
            this.btnServer.TabIndex = 2;
            this.btnServer.Text = "Create File Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnmove
            // 
            this.btnmove.Location = new System.Drawing.Point(219, 47);
            this.btnmove.Name = "btnmove";
            this.btnmove.Size = new System.Drawing.Size(129, 168);
            this.btnmove.TabIndex = 3;
            this.btnmove.Text = "Move Folder";
            this.btnmove.UseVisualStyleBackColor = true;
            this.btnmove.Click += new System.EventHandler(this.btnmove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 262);
            this.Controls.Add(this.btnmove);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnPEAQClient);
            this.Controls.Add(this.btnKIOSK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKIOSK;
        private System.Windows.Forms.Button btnPEAQClient;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnmove;
    }
}

