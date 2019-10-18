using DevExpress.XtraTreeList;
using DevExpress.XtraEditors;
using DevExpress.Utils;

namespace ToolTipControllerExample {
    public partial class Main : XtraForm {
        DetailControl flyoutControl;
        public Main() {
            InitializeComponent();
            treeList1.DataSource = DataHelper.GetData(10);
        }
        DetailControl FlyoutControl {
            get {
                if(flyoutControl == null)
                    flyoutControl = new DetailControl();
                return flyoutControl;
            }
        }
        void OnGetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e) {
            TreeList tree = e.SelectedControl as TreeList;
            if(tree != null) {
                TreeListHitInfo hitInfo = tree.CalcHitInfo(e.ControlMousePosition);
                Record record = (Record)tree.GetDataRecordByNode(hitInfo.Node);
                if(hitInfo.HitInfoType == HitInfoType.Cell) {
                    e.Info = new ToolTipControlInfo();
                    e.Info.Object = $"Column={hitInfo.Column.FieldName}, NodeId={hitInfo.Node.Id}";
                    e.Info.FlyoutControl = FlyoutControl;
                    FlyoutControl.UpdateContent(record);
                }
            }
        }
    }
}