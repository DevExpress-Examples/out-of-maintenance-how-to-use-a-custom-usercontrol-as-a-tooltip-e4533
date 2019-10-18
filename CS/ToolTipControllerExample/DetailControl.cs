using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ToolTipControllerExample {
    public partial class DetailControl : DevExpress.XtraEditors.XtraUserControl {
        public DetailControl() {
            InitializeComponent();
        }
        public void UpdateContent(Record record) {
            imageEdit.SvgImage = record.Image;
            stateToggleSwitch.EditValue = record.State;
            infoMemoEdit.EditValue = record.Info;
        }
    }
}
