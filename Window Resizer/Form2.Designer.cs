namespace Window_Resizer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.cancela = new System.Windows.Forms.Button();
            this.resizeb = new System.Windows.Forms.Button();
            this.resolutionwidth = new System.Windows.Forms.TextBox();
            this.resolutionheight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keepResolutionCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cancela
            // 
            this.cancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancela.Location = new System.Drawing.Point(119, 125);
            this.cancela.Name = "cancela";
            this.cancela.Size = new System.Drawing.Size(87, 29);
            this.cancela.TabIndex = 2;
            this.cancela.Text = "Cancel";
            this.cancela.UseVisualStyleBackColor = true;
            this.cancela.Click += new System.EventHandler(this.cancela_Click);
            // 
            // resizeb
            // 
            this.resizeb.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.resizeb.Location = new System.Drawing.Point(12, 125);
            this.resizeb.Name = "resizeb";
            this.resizeb.Size = new System.Drawing.Size(87, 29);
            this.resizeb.TabIndex = 3;
            this.resizeb.Text = "Resize";
            this.resizeb.UseVisualStyleBackColor = true;
            this.resizeb.Click += new System.EventHandler(this.resizeb_Click);
            // 
            // resolutionwidth
            // 
            this.resolutionwidth.Location = new System.Drawing.Point(18, 68);
            this.resolutionwidth.Name = "resolutionwidth";
            this.resolutionwidth.Size = new System.Drawing.Size(81, 20);
            this.resolutionwidth.TabIndex = 4;
            this.resolutionwidth.TextChanged += new System.EventHandler(this.resolutionwidth_TextChanged);
            // 
            // resolutionheight
            // 
            this.resolutionheight.Location = new System.Drawing.Point(125, 68);
            this.resolutionheight.Name = "resolutionheight";
            this.resolutionheight.Size = new System.Drawing.Size(81, 20);
            this.resolutionheight.TabIndex = 5;
            this.resolutionheight.TextChanged += new System.EventHandler(this.resolutionheight_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "What resolution should\r\nthe window be resized to?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keepResolutionCheckbox
            // 
            this.keepResolutionCheckbox.AutoSize = true;
            this.keepResolutionCheckbox.Enabled = false;
            this.keepResolutionCheckbox.Location = new System.Drawing.Point(71, 102);
            this.keepResolutionCheckbox.Name = "keepResolutionCheckbox";
            this.keepResolutionCheckbox.Size = new System.Drawing.Size(105, 17);
            this.keepResolutionCheckbox.TabIndex = 8;
            this.keepResolutionCheckbox.Text = "Keep resolution?";
            this.keepResolutionCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.resizeb;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.cancela;
            this.ClientSize = new System.Drawing.Size(223, 166);
            this.Controls.Add(this.keepResolutionCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resolutionheight);
            this.Controls.Add(this.resolutionwidth);
            this.Controls.Add(this.resizeb);
            this.Controls.Add(this.cancela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Resizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancela;
        private System.Windows.Forms.Button resizeb;
        private System.Windows.Forms.TextBox resolutionwidth;
        private System.Windows.Forms.TextBox resolutionheight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox keepResolutionCheckbox;
    }
}