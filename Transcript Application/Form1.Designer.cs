namespace database1_0
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.eklebtn = new System.Windows.Forms.Button();
            this.güncellebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.transbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eklebtn
            // 
            this.eklebtn.Location = new System.Drawing.Point(138, 220);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(113, 41);
            this.eklebtn.TabIndex = 1;
            this.eklebtn.Text = "ders ekle";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // güncellebtn
            // 
            this.güncellebtn.Location = new System.Drawing.Point(351, 220);
            this.güncellebtn.Name = "güncellebtn";
            this.güncellebtn.Size = new System.Drawing.Size(113, 41);
            this.güncellebtn.TabIndex = 2;
            this.güncellebtn.Text = "ders güncelle";
            this.güncellebtn.UseVisualStyleBackColor = true;
            this.güncellebtn.Click += new System.EventHandler(this.güncellebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(564, 220);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(113, 41);
            this.silbtn.TabIndex = 3;
            this.silbtn.Text = "sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // transbtn
            // 
            this.transbtn.Location = new System.Drawing.Point(252, 306);
            this.transbtn.Name = "transbtn";
            this.transbtn.Size = new System.Drawing.Size(317, 41);
            this.transbtn.TabIndex = 4;
            this.transbtn.Text = "transkript görüntüle";
            this.transbtn.UseVisualStyleBackColor = true;
            this.transbtn.Click += new System.EventHandler(this.transbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "BILGISAYAR MUHENDISLIGI TRANSKRIPT UYGULAMASI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transbtn);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.güncellebtn);
            this.Controls.Add(this.eklebtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.Button güncellebtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button transbtn;
        private System.Windows.Forms.Label label1;
    }
}

