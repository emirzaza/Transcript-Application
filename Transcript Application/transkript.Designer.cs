namespace database1_0
{
    partial class transkript
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
            this.transkriptdata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ganotxt = new System.Windows.Forms.TextBox();
            this.göstertransbtn = new System.Windows.Forms.Button();
            this.çıkıştransbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transkriptdata)).BeginInit();
            this.SuspendLayout();
            // 
            // transkriptdata
            // 
            this.transkriptdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transkriptdata.Location = new System.Drawing.Point(26, 12);
            this.transkriptdata.Name = "transkriptdata";
            this.transkriptdata.RowHeadersWidth = 51;
            this.transkriptdata.RowTemplate.Height = 24;
            this.transkriptdata.Size = new System.Drawing.Size(741, 250);
            this.transkriptdata.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(548, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "GANO";
            // 
            // ganotxt
            // 
            this.ganotxt.Location = new System.Drawing.Point(640, 279);
            this.ganotxt.Name = "ganotxt";
            this.ganotxt.ReadOnly = true;
            this.ganotxt.Size = new System.Drawing.Size(127, 22);
            this.ganotxt.TabIndex = 3;
            // 
            // göstertransbtn
            // 
            this.göstertransbtn.Location = new System.Drawing.Point(253, 348);
            this.göstertransbtn.Name = "göstertransbtn";
            this.göstertransbtn.Size = new System.Drawing.Size(314, 70);
            this.göstertransbtn.TabIndex = 4;
            this.göstertransbtn.Text = "TRANSKRİPT VE GANO GÖSTER";
            this.göstertransbtn.UseVisualStyleBackColor = true;
            this.göstertransbtn.Click += new System.EventHandler(this.göstertransbtn_Click);
            // 
            // çıkıştransbtn
            // 
            this.çıkıştransbtn.Location = new System.Drawing.Point(692, 415);
            this.çıkıştransbtn.Name = "çıkıştransbtn";
            this.çıkıştransbtn.Size = new System.Drawing.Size(75, 23);
            this.çıkıştransbtn.TabIndex = 5;
            this.çıkıştransbtn.Text = "çıkış";
            this.çıkıştransbtn.UseVisualStyleBackColor = true;
            this.çıkıştransbtn.Click += new System.EventHandler(this.çıkıştransbtn_Click);
            // 
            // transkript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.çıkıştransbtn);
            this.Controls.Add(this.göstertransbtn);
            this.Controls.Add(this.ganotxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transkriptdata);
            this.Name = "transkript";
            this.Text = "transkript";
            ((System.ComponentModel.ISupportInitialize)(this.transkriptdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView transkriptdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ganotxt;
        private System.Windows.Forms.Button göstertransbtn;
        private System.Windows.Forms.Button çıkıştransbtn;
    }
}