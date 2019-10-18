namespace ToolTipControllerExample {
    partial class DetailControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.imageEdit = new DevExpress.XtraEditors.PictureEdit();
            this.stateToggleSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.infoMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateToggleSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.infoMemoEdit);
            this.tablePanel1.Controls.Add(this.stateToggleSwitch);
            this.tablePanel1.Controls.Add(this.imageEdit);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Size = new System.Drawing.Size(321, 215);
            this.tablePanel1.TabIndex = 0;
            // 
            // pictureEdit
            // 
            this.tablePanel1.SetColumn(this.imageEdit, 0);
            this.imageEdit.Location = new System.Drawing.Point(3, 6);
            this.imageEdit.Name = "pictureEdit";
            this.imageEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.tablePanel1.SetRow(this.imageEdit, 0);
            this.imageEdit.Size = new System.Drawing.Size(155, 96);
            this.imageEdit.TabIndex = 0;
            // 
            // stateToggleSwitch
            // 
            this.tablePanel1.SetColumn(this.stateToggleSwitch, 0);
            this.stateToggleSwitch.Location = new System.Drawing.Point(3, 152);
            this.stateToggleSwitch.Name = "stateToggleSwitch";
            this.stateToggleSwitch.Properties.OffText = "InActive";
            this.stateToggleSwitch.Properties.OnText = "Active";
            this.tablePanel1.SetRow(this.stateToggleSwitch, 1);
            this.stateToggleSwitch.Size = new System.Drawing.Size(155, 18);
            this.stateToggleSwitch.TabIndex = 1;
            // 
            // infoMemoEdit
            // 
            this.tablePanel1.SetColumn(this.infoMemoEdit, 1);
            this.infoMemoEdit.Location = new System.Drawing.Point(164, 113);
            this.infoMemoEdit.Name = "infoMemoEdit";
            this.tablePanel1.SetRow(this.infoMemoEdit, 1);
            this.infoMemoEdit.Size = new System.Drawing.Size(155, 96);
            this.infoMemoEdit.TabIndex = 2;
            // 
            // DetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "DetailControl";
            this.Size = new System.Drawing.Size(321, 215);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateToggleSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoMemoEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.ToggleSwitch stateToggleSwitch;
        private DevExpress.XtraEditors.PictureEdit imageEdit;
        private DevExpress.XtraEditors.MemoEdit infoMemoEdit;
    }
}
