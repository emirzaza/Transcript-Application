namespace database1_0
{
    partial class sil
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
            this.silinecekid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sildata = new System.Windows.Forms.DataGridView();
            this.silgöster = new System.Windows.Forms.Button();
            this.dersisilbtn = new System.Windows.Forms.Button();
            this.çıkışsilbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sildata)).BeginInit();
            this.SuspendLayout();
            // 
            // silinecekid
            // 
            this.silinecekid.Location = new System.Drawing.Point(445, 289);
            this.silinecekid.Name = "silinecekid";
            this.silinecekid.Size = new System.Drawing.Size(100, 22);
            this.silinecekid.TabIndex = 61;
            this.silinecekid.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "silmek istediğiniz ders kodunu girinis:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sildata
            // 
            this.sildata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sildata.Location = new System.Drawing.Point(27, 30);
            this.sildata.Name = "sildata";
            this.sildata.RowHeadersWidth = 51;
            this.sildata.RowTemplate.Height = 24;
            this.sildata.Size = new System.Drawing.Size(741, 172);
            this.sildata.TabIndex = 62;
            // 
            // silgöster
            // 
            this.silgöster.Location = new System.Drawing.Point(288, 208);
            this.silgöster.Name = "silgöster";
            this.silgöster.Size = new System.Drawing.Size(216, 23);
            this.silgöster.TabIndex = 63;
            this.silgöster.Text = "TRANSKRİPT GÖSTER";
            this.silgöster.UseVisualStyleBackColor = true;
            this.silgöster.Click += new System.EventHandler(this.silgöster_Click);
            // 
            // dersisilbtn
            // 
            this.dersisilbtn.Location = new System.Drawing.Point(233, 350);
            this.dersisilbtn.Name = "dersisilbtn";
            this.dersisilbtn.Size = new System.Drawing.Size(312, 59);
            this.dersisilbtn.TabIndex = 64;
            this.dersisilbtn.Text = "DERSİ SİL";
            this.dersisilbtn.UseVisualStyleBackColor = true;
            this.dersisilbtn.Click += new System.EventHandler(this.dersisilbtn_Click);
            // 
            // çıkışsilbtn
            // 
            this.çıkışsilbtn.Location = new System.Drawing.Point(700, 403);
            this.çıkışsilbtn.Name = "çıkışsilbtn";
            this.çıkışsilbtn.Size = new System.Drawing.Size(75, 23);
            this.çıkışsilbtn.TabIndex = 65;
            this.çıkışsilbtn.Text = "çıkış";
            this.çıkışsilbtn.UseVisualStyleBackColor = true;
            this.çıkışsilbtn.Click += new System.EventHandler(this.çıkışsilbtn_Click);
            // 
            // sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.çıkışsilbtn);
            this.Controls.Add(this.dersisilbtn);
            this.Controls.Add(this.silgöster);
            this.Controls.Add(this.sildata);
            this.Controls.Add(this.silinecekid);
            this.Controls.Add(this.label2);
            this.Name = "sil";
            this.Text = "sil";
            this.Load += new System.EventHandler(this.sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sildata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox silinecekid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView sildata;
        private System.Windows.Forms.Button silgöster;
        private System.Windows.Forms.Button dersisilbtn;
        private System.Windows.Forms.Button çıkışsilbtn;
    }
}