Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace GridControlLocalization
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.DataSource = New ProductList()
			GridControlLocalizer.Active = New CustomGridLocalizer()
		End Sub
	End Class

	Public Class CustomGridLocalizer
		Inherits GridControlLocalizer
		Protected Overrides Sub PopulateStringTable()
			MyBase.PopulateStringTable()
			' Changes the caption of the menu item used to invoke the Total Summary Editor.
			AddString(GridControlStringId.MenuFooterCustomize, "Customize Totals")
			' Changes the Total Summary Editor's default caption.
			AddString(GridControlStringId.TotalSummaryEditorFormCaption, "Totals Editor")
		End Sub
	End Class

End Namespace
