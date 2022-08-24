using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_Editor
{
    public partial class Form1 : Form
    {
        private string FormTitle = "Not Editor";
        private TextDocument doc = new TextDocument();
        public Form1()
        {
            InitializeComponent();
        }

        private void Write2Log(string str)
        {
            txt_log.Text = str + "\r\n" + txt_log.Text;
        }
        private void SetTitle()
        {
            this.Text = $"{FormTitle} - {doc.Title}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetTitle();
            fontDialog1.Font = txt_Doc.Font;

        }

        private void txt_Doc_TextChanged(object sender, EventArgs e)
        {
            Write2Log("Doc değişti");
            doc.Body = txt_Doc.Text;
            SetTitle();
            stat_CharCount.Text = "Char : " + doc.CharCount;
            stat_WordCount.Text = "Word : " + doc.WordCount;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(doc.FullName))
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    doc.FullName = saveFileDialog1.FileName;
                    Write2Log(saveFileDialog1.FileName);
                }
                else
                {
                    Write2Log("cancel");
                    return;
                }
            }
            File.WriteAllText(doc.FullName, doc.Body);
            doc.IsModified = false;
            SetTitle();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_Doc.Text = File.ReadAllText(openFileDialog1.FileName);
                doc.IsModified = false;
                doc.FullName = openFileDialog1.FileName;
                SetTitle();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_Doc.Font = fontDialog1.Font;
                Write2Log(fontDialog1.Font.ToString());
            }
        }

    

        private void btn_New_Click(object sender, EventArgs e)
        {
            if (doc.IsModified)
            {
                var buttons = MessageBoxButtons.YesNo;
                var icon = MessageBoxIcon.Warning;
                if (MessageBox.Show("Dosya Kaydedilmedi. Kaydetmek istiyormsunuz?", "Dikkat", buttons, icon) == DialogResult.Yes)
                {
                    btn_Save_Click(null, null);
                }
            }
            doc = new TextDocument();
            txt_Doc.Text = "";
            doc.IsModified = false;
            SetTitle();
        }

        private void btn_ShowLog_Click(object sender, EventArgs e)
        {
            pnl_Log.Visible = !pnl_Log.Visible;
            btn_ShowLog.Checked = pnl_Log.Visible;
        }

        private void btn_Align_Left_Click(object sender, EventArgs e)
        {
            txt_Doc.TextAlign = HorizontalAlignment.Left;
        }

        private void btn_Align_Center_Click(object sender, EventArgs e)
        {
            txt_Doc.TextAlign = HorizontalAlignment.Center;
        }

        private void btn_Align_Rigth_Click(object sender, EventArgs e)
        {
            txt_Doc.TextAlign = HorizontalAlignment.Right;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frm_Info frm = new frm_Info();
            frm.doc = doc;
            frm.ShowDialog();
        }
    }
}
