using System.Windows.Controls;
using DevExpress.Xpf.Grid;

namespace GridControlLocalization {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.ItemsSource = new ProductList();
            GridControlLocalizer.Active = new CustomGridLocalizer();
        }
    }

    public class CustomGridLocalizer : GridControlLocalizer {
        protected override void PopulateStringTable() {
            base.PopulateStringTable();
            // Changes the caption of the menu item used to invoke the Total Summary Editor.
            AddString(GridControlStringId.MenuFooterCustomize, "Customize Totals");
            // Changes the Total Summary Editor's default caption.
            AddString(GridControlStringId.TotalSummaryEditorFormCaption, "Totals Editor");
        }
    }

}
