using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_Editor
{
    public partial class frm_Info : Form
    {
        public frm_Info()
        {
            InitializeComponent();
        }
        public TextDocument doc { get; set; } = new TextDocument();

        private void frm_Info_Load(object sender, EventArgs e)
        {

        }

        private void frm_Info_Shown(object sender, EventArgs e)
        {
            lbl_Fulname.Text = doc.FullName;
            lbl_Name.Text= doc.Name;
            lbl_WordCount.Text = doc.WordCount.ToString();
            lbl_CharCount.Text = doc.CharCount.ToString();
        }
    }
}
