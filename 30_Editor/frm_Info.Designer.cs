namespace _30_Editor
{
    partial class frm_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Info));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Fulname = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_WordCount = new System.Windows.Forms.Label();
            this.lbl_CharCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Tamadi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dosya Adi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelime sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Karakter Sayısı";
            // 
            // lbl_Fulname
            // 
            this.lbl_Fulname.AutoSize = true;
            this.lbl_Fulname.Location = new System.Drawing.Point(121, 25);
            this.lbl_Fulname.Name = "lbl_Fulname";
            this.lbl_Fulname.Size = new System.Drawing.Size(35, 13);
            this.lbl_Fulname.TabIndex = 6;
            this.lbl_Fulname.Text = "label7";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(121, 57);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "label8";
            // 
            // lbl_WordCount
            // 
            this.lbl_WordCount.AutoSize = true;
            this.lbl_WordCount.Location = new System.Drawing.Point(121, 90);
            this.lbl_WordCount.Name = "lbl_WordCount";
            this.lbl_WordCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_WordCount.TabIndex = 8;
            this.lbl_WordCount.Text = "label9";
            // 
            // lbl_CharCount
            // 
            this.lbl_CharCount.AutoSize = true;
            this.lbl_CharCount.Location = new System.Drawing.Point(122, 117);
            this.lbl_CharCount.Name = "lbl_CharCount";
            this.lbl_CharCount.Size = new System.Drawing.Size(41, 13);
            this.lbl_CharCount.TabIndex = 9;
            this.lbl_CharCount.Text = "label10";
            // 
            // frm_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 155);
            this.Controls.Add(this.lbl_CharCount);
            this.Controls.Add(this.lbl_WordCount);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Fulname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Document Info";
            this.Load += new System.EventHandler(this.frm_Info_Load);
            this.Shown += new System.EventHandler(this.frm_Info_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Fulname;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_WordCount;
        private System.Windows.Forms.Label lbl_CharCount;
    }
}