using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            ShowPrintPreview();
        }
        private static void ShowPrintPreview() {
            XtraReport report = new XtraReport1();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
