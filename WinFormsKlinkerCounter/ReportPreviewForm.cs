using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsKlinkerCounter
{
    public partial class ReportPreviewForm : Form
    {
        public ReportPreviewForm()
        {
            InitializeComponent();
        }

        private void ReportPreviewForm_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.ReportPath =@"D:\My Projects\C#\WinFormsKlinkerCounter  V3.0\WinFormsKlinkerCounter\Report1.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
