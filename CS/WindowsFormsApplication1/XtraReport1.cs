using System;
using System.Drawing;
using DevExpress.XtraPrinting;

namespace WindowsFormsApplication1 {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
            PrintingSystem.AfterMarginsChange += PrintingSystem_AfterMarginsChange;
            PrintingSystem.PageSettingsChanged += PrintingSystem_PageSettingsChanged;
        }

        private void PrintingSystem_AfterMarginsChange(object sender, DevExpress.XtraPrinting.MarginsChangeEventArgs e) {
            Convert.ToInt32(Math.Round(e.Value));
            switch (e.Side) {
                case DevExpress.XtraPrinting.MarginSide.Left:
                    Margins = new System.Drawing.Printing.Margins((int)e.Value, Margins.Right, Margins.Top, Margins.Bottom);
                    CreateDocument();
                    break;
                case DevExpress.XtraPrinting.MarginSide.Right:
                    Margins = new System.Drawing.Printing.Margins(Margins.Left, (int)e.Value, Margins.Top, Margins.Bottom);
                    CreateDocument();
                    break;
                case DevExpress.XtraPrinting.MarginSide.All:
                    Margins = (sender as DevExpress.XtraPrinting.PrintingSystemBase).PageSettings.Margins;
                    CreateDocument();
                    break;
                default:
                    break;
            }
        }
        private void PrintingSystem_PageSettingsChanged(object sender, EventArgs e) {
            XtraPageSettingsBase pageSettings = ((PrintingSystemBase)sender).PageSettings;
            PaperKind = pageSettings.PaperKind;
            Landscape = pageSettings.Landscape;
            Margins = new System.Drawing.Printing.Margins(pageSettings.LeftMargin, pageSettings.RightMargin, pageSettings.TopMargin, pageSettings.BottomMargin);
            CreateDocument();
        }
        private void AdjustControls() {
            float newWidth = PageWidth - Margins.Left - Margins.Right;
            float newHeight = PageHeight - Margins.Top - Margins.Bottom - PageHeader.HeightF - PageFooter.HeightF;
            xrPictureBox1.SizeF = new SizeF(newWidth, newHeight);
            xrLabel1.WidthF = newWidth;
            xrLabel2.WidthF = newWidth;
        }

        private void XtraReport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            AdjustControls();
        }
    }
}
