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

namespace Rojnishi
{
    public partial class DiaryPage : Form
    {
        public DiaryPage()
        {
            InitializeComponent();
        }
        public string text_toWrite="";
        private void btnSave_Click(object sender, EventArgs e)
        {
            text_toWrite = txt_editor.Text;
            string filePath_ = DateTime.Now.Date.ToString("yyyyMMdd") + ".txt";
           
            using (FileStream fs = new FileStream(filePath_, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(text_toWrite);
                }
            }
        }

        private void DiaryPage_Load(object sender, EventArgs e)
        {
            txt_editor.AppendText("\t\t"+DateTime.Now.Date.ToLongDateString()+Environment.NewLine + Environment.NewLine);
        }
    }
}
