namespace Vigernere1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_PlaintText = new System.Windows.Forms.TextBox();
            this.txb_Key = new System.Windows.Forms.TextBox();
            this.txb_DecryptText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_CipherText = new System.Windows.Forms.TextBox();
            this.btn_Mahoa = new System.Windows.Forms.Button();
            this.btn_Giaima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bản rõ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giải Mã";
            // 
            // txb_PlaintText
            // 
            this.txb_PlaintText.Location = new System.Drawing.Point(62, 94);
            this.txb_PlaintText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_PlaintText.Multiline = true;
            this.txb_PlaintText.Name = "txb_PlaintText";
            this.txb_PlaintText.Size = new System.Drawing.Size(418, 34);
            this.txb_PlaintText.TabIndex = 3;
            // 
            // txb_Key
            // 
            this.txb_Key.Location = new System.Drawing.Point(303, 43);
            this.txb_Key.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_Key.Multiline = true;
            this.txb_Key.Name = "txb_Key";
            this.txb_Key.Size = new System.Drawing.Size(177, 30);
            this.txb_Key.TabIndex = 4;
            // 
            // txb_DecryptText
            // 
            this.txb_DecryptText.Location = new System.Drawing.Point(60, 304);
            this.txb_DecryptText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_DecryptText.Multiline = true;
            this.txb_DecryptText.Name = "txb_DecryptText";
            this.txb_DecryptText.Size = new System.Drawing.Size(420, 32);
            this.txb_DecryptText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bản mã";
            // 
            // txb_CipherText
            // 
            this.txb_CipherText.Location = new System.Drawing.Point(62, 195);
            this.txb_CipherText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_CipherText.Multiline = true;
            this.txb_CipherText.Name = "txb_CipherText";
            this.txb_CipherText.Size = new System.Drawing.Size(418, 32);
            this.txb_CipherText.TabIndex = 7;
            // 
            // btn_Mahoa
            // 
            this.btn_Mahoa.Location = new System.Drawing.Point(339, 146);
            this.btn_Mahoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Mahoa.Name = "btn_Mahoa";
            this.btn_Mahoa.Size = new System.Drawing.Size(112, 31);
            this.btn_Mahoa.TabIndex = 8;
            this.btn_Mahoa.Text = "Mã hóa";
            this.btn_Mahoa.UseVisualStyleBackColor = true;
            this.btn_Mahoa.Click += new System.EventHandler(this.btn_Mahoa_Click);
            // 
            // btn_Giaima
            // 
            this.btn_Giaima.Location = new System.Drawing.Point(335, 256);
            this.btn_Giaima.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Giaima.Name = "btn_Giaima";
            this.btn_Giaima.Size = new System.Drawing.Size(112, 31);
            this.btn_Giaima.TabIndex = 9;
            this.btn_Giaima.Text = "Giải mã";
            this.btn_Giaima.UseVisualStyleBackColor = true;
            this.btn_Giaima.Click += new System.EventHandler(this.btn_Giaima_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 350);
            this.Controls.Add(this.btn_Giaima);
            this.Controls.Add(this.btn_Mahoa);
            this.Controls.Add(this.txb_CipherText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_DecryptText);
            this.Controls.Add(this.txb_Key);
            this.Controls.Add(this.txb_PlaintText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_PlaintText;
        private System.Windows.Forms.TextBox txb_Key;
        private System.Windows.Forms.TextBox txb_DecryptText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_CipherText;
        private System.Windows.Forms.Button btn_Mahoa;
        private System.Windows.Forms.Button btn_Giaima;
    }
}

