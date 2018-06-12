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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKIOSK
            // 
            this.btnKIOSK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnKIOSK.Location = new System.Drawing.Point(139, 110);
            this.btnKIOSK.Name = "btnKIOSK";
            this.btnKIOSK.Size = new System.Drawing.Size(151, 42);
            this.btnKIOSK.TabIndex = 0;
            this.btnKIOSK.Text = "Create File KIOSK";
            this.btnKIOSK.UseVisualStyleBackColor = true;
            this.btnKIOSK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPEAQClient
            // 
            this.btnPEAQClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnPEAQClient.Location = new System.Drawing.Point(139, 173);
            this.btnPEAQClient.Name = "btnPEAQClient";
            this.btnPEAQClient.Size = new System.Drawing.Size(151, 42);
            this.btnPEAQClient.TabIndex = 1;
            this.btnPEAQClient.Text = "Create File PEAQClient";
            this.btnPEAQClient.UseVisualStyleBackColor = true;
            this.btnPEAQClient.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnServer
            // 
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnServer.Location = new System.Drawing.Point(139, 47);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(151, 42);
            this.btnServer.TabIndex = 2;
            this.btnServer.Text = "Create File Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnmove
            // 
            this.btnmove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnmove.Location = new System.Drawing.Point(402, 47);
            this.btnmove.Name = "btnmove";
            this.btnmove.Size = new System.Drawing.Size(129, 168);
            this.btnmove.TabIndex = 3;
            this.btnmove.Text = "Move Folder";
            this.btnmove.UseVisualStyleBackColor = true;
            this.btnmove.Click += new System.EventHandler(this.btnmove_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(402, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(495, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(80, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "D:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Part   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(80, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Warnings : Do not select a file whose name has spaces.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::WindowsFormsApp1.Properties.Resources.warning;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.warning__1_;
            this.pictureBox1.InitialImage = global::WindowsFormsApp1.Properties.Resources.warning__1_;
            this.pictureBox1.Location = new System.Drawing.Point(37, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 39);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::WindowsFormsApp1.Properties.Resources.warning;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.warning__1_;
            this.pictureBox2.InitialImage = global::WindowsFormsApp1.Properties.Resources.warning__1_;
            this.pictureBox2.Location = new System.Drawing.Point(464, 296);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 39);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 347);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnmove);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnPEAQClient);
            this.Controls.Add(this.btnKIOSK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKIOSK;
        private System.Windows.Forms.Button btnPEAQClient;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnmove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

