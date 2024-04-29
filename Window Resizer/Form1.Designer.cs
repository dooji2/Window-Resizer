namespace Window_Resizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clend = new System.Windows.Forms.Button();
            this.clkeeprunning = new System.Windows.Forms.Button();
            this.runats = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gtb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clend
            // 
            this.clend.Location = new System.Drawing.Point(12, 59);
            this.clend.Name = "clend";
            this.clend.Size = new System.Drawing.Size(224, 41);
            this.clend.TabIndex = 0;
            this.clend.Text = "Close (end program)";
            this.clend.UseVisualStyleBackColor = true;
            this.clend.Click += new System.EventHandler(this.button1_Click);
            // 
            // clkeeprunning
            // 
            this.clkeeprunning.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clkeeprunning.Location = new System.Drawing.Point(12, 12);
            this.clkeeprunning.Name = "clkeeprunning";
            this.clkeeprunning.Size = new System.Drawing.Size(224, 41);
            this.clkeeprunning.TabIndex = 1;
            this.clkeeprunning.Text = "Close (keep running)";
            this.clkeeprunning.UseVisualStyleBackColor = true;
            this.clkeeprunning.Click += new System.EventHandler(this.clkeeprunning_Click);
            // 
            // runats
            // 
            this.runats.AutoSize = true;
            this.runats.Location = new System.Drawing.Point(71, 106);
            this.runats.Name = "runats";
            this.runats.Size = new System.Drawing.Size(99, 17);
            this.runats.TabIndex = 2;
            this.runats.Text = "Run at startup?";
            this.runats.UseVisualStyleBackColor = true;
            this.runats.CheckedChanged += new System.EventHandler(this.runats_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Window_Resizer.Properties.Resources._52493784;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "By Dooji";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gtb
            // 
            this.gtb.Location = new System.Drawing.Point(161, 131);
            this.gtb.Name = "gtb";
            this.gtb.Size = new System.Drawing.Size(75, 23);
            this.gtb.TabIndex = 5;
            this.gtb.Text = "GitHub";
            this.gtb.UseVisualStyleBackColor = true;
            this.gtb.Click += new System.EventHandler(this.Gtb);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.clkeeprunning;
            this.ClientSize = new System.Drawing.Size(248, 168);
            this.Controls.Add(this.gtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.runats);
            this.Controls.Add(this.clkeeprunning);
            this.Controls.Add(this.clend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Resizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clend;
        private System.Windows.Forms.Button clkeeprunning;
        private System.Windows.Forms.CheckBox runats;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gtb;
    }
}

