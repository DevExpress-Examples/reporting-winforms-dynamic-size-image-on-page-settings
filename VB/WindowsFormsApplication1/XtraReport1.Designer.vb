Namespace WindowsFormsApplication1
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1})
			Me.Detail.HeightF = 100F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.Image = (DirectCast(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image))
			Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(627F, 100F)
			Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.PageHeader.HeightF = 100F
			Me.PageHeader.Name = "PageHeader"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.PowderBlue
			Me.xrLabel1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(627F, 100F)
			Me.xrLabel1.StylePriority.UseBackColor = False
			Me.xrLabel1.StylePriority.UseBorders = False
			Me.xrLabel1.StylePriority.UseTextAlignment = False
			Me.xrLabel1.Text = "Page Header area"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' PageFooter
			' 
			Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
			Me.PageFooter.HeightF = 100F
			Me.PageFooter.Name = "PageFooter"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.BackColor = System.Drawing.Color.Gold
			Me.xrLabel2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(627F, 100F)
			Me.xrLabel2.StylePriority.UseBackColor = False
			Me.xrLabel2.StylePriority.UseBorders = False
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "Page Footer area"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter})
			Me.PageHeight = 1169
			Me.PageWidth = 827
			Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
			Me.Version = "15.1"
'			Me.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.XtraReport1_BeforePrint)
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
