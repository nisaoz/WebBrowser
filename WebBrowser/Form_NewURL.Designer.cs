namespace WebBrowser
{
    partial class Form_NewURL
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
            this.txtbox_URL = new System.Windows.Forms.TextBox();
            this.btn_tamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL: ";
            // 
            // txtbox_URL
            // 
            this.txtbox_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_URL.Location = new System.Drawing.Point(163, 40);
            this.txtbox_URL.Name = "txtbox_URL";
            this.txtbox_URL.Size = new System.Drawing.Size(187, 30);
            this.txtbox_URL.TabIndex = 1;
            // 
            // btn_tamam
            // 
            this.btn_tamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tamam.Location = new System.Drawing.Point(232, 97);
            this.btn_tamam.Name = "btn_tamam";
            this.btn_tamam.Size = new System.Drawing.Size(118, 41);
            this.btn_tamam.TabIndex = 2;
            this.btn_tamam.Text = "Tamam";
            this.btn_tamam.UseVisualStyleBackColor = true;
            this.btn_tamam.Click += new System.EventHandler(this.btn_tamam_Click);
            // 
            // NewURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 150);
            this.Controls.Add(this.btn_tamam);
            this.Controls.Add(this.txtbox_URL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewURL";
            this.Text = "NewURL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_URL;
        private System.Windows.Forms.Button btn_tamam;
    }
}