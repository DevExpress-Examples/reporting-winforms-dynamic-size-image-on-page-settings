Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting

Namespace WindowsFormsApplication1
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
			AddHandler PrintingSystem.AfterMarginsChange, AddressOf PrintingSystem_AfterMarginsChange
			AddHandler PrintingSystem.PageSettingsChanged, AddressOf PrintingSystem_PageSettingsChanged
		End Sub

		Private Sub PrintingSystem_AfterMarginsChange(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.MarginsChangeEventArgs)
			Convert.ToInt32(Math.Round(e.Value))
			Select Case e.Side
				Case DevExpress.XtraPrinting.MarginSide.Left
					Margins = New System.Drawing.Printing.Margins(CInt(Math.Truncate(e.Value)), Margins.Right, Margins.Top, Margins.Bottom)
					CreateDocument()
				Case DevExpress.XtraPrinting.MarginSide.Right
					Margins = New System.Drawing.Printing.Margins(Margins.Left, CInt(Math.Truncate(e.Value)), Margins.Top, Margins.Bottom)
					CreateDocument()
				Case DevExpress.XtraPrinting.MarginSide.All
					Margins = (TryCast(sender, DevExpress.XtraPrinting.PrintingSystemBase)).PageSettings.Margins
					CreateDocument()
				Case Else
			End Select
		End Sub
		Private Sub PrintingSystem_PageSettingsChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim pageSettings As XtraPageSettingsBase = DirectCast(sender, PrintingSystemBase).PageSettings
			PaperKind = pageSettings.PaperKind
			Landscape = pageSettings.Landscape
			Margins = New System.Drawing.Printing.Margins(pageSettings.LeftMargin, pageSettings.RightMargin, pageSettings.TopMargin, pageSettings.BottomMargin)
			CreateDocument()
		End Sub
		Private Sub AdjustControls()
			Dim newWidth As Single = PageWidth - Margins.Left - Margins.Right
			Dim newHeight As Single = PageHeight - Margins.Top - Margins.Bottom - PageHeader.HeightF - PageFooter.HeightF
			xrPictureBox1.SizeF = New SizeF(newWidth, newHeight)
			xrLabel1.WidthF = newWidth
			xrLabel2.WidthF = newWidth
		End Sub

		Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
			AdjustControls()
		End Sub
	End Class
End Namespace
