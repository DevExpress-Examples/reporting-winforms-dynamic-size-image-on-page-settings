Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			ShowPrintPreview()
		End Sub
		Private Shared Sub ShowPrintPreview()
			Dim report As XtraReport = New XtraReport1()
			Dim printTool As New ReportPrintTool(report)
			printTool.ShowPreviewDialog()
		End Sub
	End Class
End Namespace
