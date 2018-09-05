namespace checkUpdate
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
            this.lbtenungdung = new System.Windows.Forms.Label();
            this.lbnoidung = new System.Windows.Forms.Label();
            this.pbloading = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbloading)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtenungdung
            // 
            this.lbtenungdung.AutoSize = true;
            this.lbtenungdung.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenungdung.Location = new System.Drawing.Point(12, 9);
            this.lbtenungdung.Name = "lbtenungdung";
            this.lbtenungdung.Size = new System.Drawing.Size(32, 23);
            this.lbtenungdung.TabIndex = 0;
            this.lbtenungdung.Text = "hts";
            // 
            // lbnoidung
            // 
            this.lbnoidung.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnoidung.Location = new System.Drawing.Point(16, 58);
            this.lbnoidung.Name = "lbnoidung";
            this.lbnoidung.Size = new System.Drawing.Size(472, 39);
            this.lbnoidung.TabIndex = 0;
            this.lbnoidung.Text = "Đang kiểm tra cập nhật ...";
            this.lbnoidung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbloading
            // 
            this.pbloading.Image = ((System.Drawing.Image)(resources.GetObject("pbloading.Image")));
            this.pbloading.Location = new System.Drawing.Point(192, 100);
            this.pbloading.Name = "pbloading";
            this.pbloading.Size = new System.Drawing.Size(147, 95);
            this.pbloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbloading.TabIndex = 1;
            this.pbloading.TabStop = false;
            this.pbloading.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "hts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.pbloading);
            this.Controls.Add(this.lbnoidung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtenungdung);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "check update";
            ((System.ComponentModel.ISupportInitialize)(this.pbloading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtenungdung;
        private System.Windows.Forms.Label lbnoidung;
        private System.Windows.Forms.PictureBox pbloading;
        private System.Windows.Forms.Label label2;
    }
}

