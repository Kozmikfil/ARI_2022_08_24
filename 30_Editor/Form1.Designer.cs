namespace _30_Editor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Doc = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stat_CharCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.stat_WordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnl_Log = new System.Windows.Forms.Panel();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_New = new System.Windows.Forms.ToolStripButton();
            this.btn_Open = new System.Windows.Forms.ToolStripButton();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btn_ShowLog = new System.Windows.Forms.ToolStripButton();
            this.btn_Align_Left = new System.Windows.Forms.ToolStripButton();
            this.btn_Align_Center = new System.Windows.Forms.ToolStripButton();
            this.btn_Align_Rigth = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnl_Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Doc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(567, 357);
            this.panel1.TabIndex = 1;
            // 
            // txt_Doc
            // 
            this.txt_Doc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Doc.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Doc.Location = new System.Drawing.Point(10, 10);
            this.txt_Doc.Margin = new System.Windows.Forms.Padding(10);
            this.txt_Doc.Multiline = true;
            this.txt_Doc.Name = "txt_Doc";
            this.txt_Doc.Size = new System.Drawing.Size(547, 337);
            this.txt_Doc.TabIndex = 0;
            this.txt_Doc.TextChanged += new System.EventHandler(this.txt_Doc_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_New,
            this.btn_Open,
            this.btn_Save,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.btn_ShowLog,
            this.toolStripSeparator2,
            this.btn_Align_Left,
            this.btn_Align_Center,
            this.btn_Align_Rigth,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 71);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stat_CharCount,
            this.stat_WordCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stat_CharCount
            // 
            this.stat_CharCount.Name = "stat_CharCount";
            this.stat_CharCount.Size = new System.Drawing.Size(118, 17);
            this.stat_CharCount.Text = "toolStripStatusLabel1";
            // 
            // stat_WordCount
            // 
            this.stat_WordCount.Name = "stat_WordCount";
            this.stat_WordCount.Size = new System.Drawing.Size(118, 17);
            this.stat_WordCount.Text = "toolStripStatusLabel1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // pnl_Log
            // 
            this.pnl_Log.Controls.Add(this.txt_log);
            this.pnl_Log.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Log.Location = new System.Drawing.Point(567, 71);
            this.pnl_Log.Name = "pnl_Log";
            this.pnl_Log.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Log.Size = new System.Drawing.Size(233, 357);
            this.pnl_Log.TabIndex = 2;
            // 
            // txt_log
            // 
            this.txt_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_log.Location = new System.Drawing.Point(10, 10);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(213, 337);
            this.txt_log.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // btn_New
            // 
            this.btn_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_New.Image = global::_30_Editor.Properties.Resources._new;
            this.btn_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(68, 68);
            this.btn_New.Text = "Yeni Dosya";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Open.Image = global::_30_Editor.Properties.Resources.open;
            this.btn_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(68, 68);
            this.btn_Open.Text = "toolStripButton2";
            this.btn_Open.ToolTipText = "Dosya Aç";
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Save.Image = global::_30_Editor.Properties.Resources.save;
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(68, 68);
            this.btn_Save.Text = "toolStripButton3";
            this.btn_Save.ToolTipText = "Kaydet";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.CheckOnClick = true;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::_30_Editor.Properties.Resources.font;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 68);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btn_ShowLog
            // 
            this.btn_ShowLog.Checked = true;
            this.btn_ShowLog.CheckOnClick = true;
            this.btn_ShowLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_ShowLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ShowLog.Image = global::_30_Editor.Properties.Resources.settings;
            this.btn_ShowLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ShowLog.Name = "btn_ShowLog";
            this.btn_ShowLog.Size = new System.Drawing.Size(68, 68);
            this.btn_ShowLog.Text = "toolStripButton2";
            this.btn_ShowLog.Click += new System.EventHandler(this.btn_ShowLog_Click);
            // 
            // btn_Align_Left
            // 
            this.btn_Align_Left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Align_Left.Image = global::_30_Editor.Properties.Resources.Text_align_left_icon;
            this.btn_Align_Left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Align_Left.Name = "btn_Align_Left";
            this.btn_Align_Left.Size = new System.Drawing.Size(68, 68);
            this.btn_Align_Left.Text = "toolStripButton2";
            this.btn_Align_Left.Click += new System.EventHandler(this.btn_Align_Left_Click);
            // 
            // btn_Align_Center
            // 
            this.btn_Align_Center.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Align_Center.Image = global::_30_Editor.Properties.Resources.Text_align_center_icon;
            this.btn_Align_Center.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Align_Center.Name = "btn_Align_Center";
            this.btn_Align_Center.Size = new System.Drawing.Size(68, 68);
            this.btn_Align_Center.Text = "toolStripButton3";
            this.btn_Align_Center.Click += new System.EventHandler(this.btn_Align_Center_Click);
            // 
            // btn_Align_Rigth
            // 
            this.btn_Align_Rigth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Align_Rigth.Image = global::_30_Editor.Properties.Resources.Text_align_right_icon;
            this.btn_Align_Rigth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Align_Rigth.Name = "btn_Align_Rigth";
            this.btn_Align_Rigth.Size = new System.Drawing.Size(68, 68);
            this.btn_Align_Rigth.Text = "toolStripButton4";
            this.btn_Align_Rigth.Click += new System.EventHandler(this.btn_Align_Rigth_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::_30_Editor.Properties.Resources.info_icon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(68, 68);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Log);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnl_Log.ResumeLayout(false);
            this.pnl_Log.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Doc;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_New;
        private System.Windows.Forms.ToolStripButton btn_Open;
        private System.Windows.Forms.ToolStripButton btn_Save;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stat_CharCount;
        private System.Windows.Forms.ToolStripStatusLabel stat_WordCount;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel pnl_Log;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton btn_ShowLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Align_Left;
        private System.Windows.Forms.ToolStripButton btn_Align_Center;
        private System.Windows.Forms.ToolStripButton btn_Align_Rigth;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

