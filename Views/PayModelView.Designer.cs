namespace Supermarket_mvp.Views
{
    partial class PayModeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayModeView));
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ImgBuy = new PictureBox();
            lbPayMode = new Label();
            tabControl2 = new TabControl();
            tabPayModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label1 = new Label();
            tabPagePayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            TxtPayModeObservation = new TextBox();
            TxtPayModeName = new TextBox();
            TxtPayModeId = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImgBuy).BeginInit();
            tabControl2.SuspendLayout();
            tabPayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(ImgBuy);
            panel1.Controls.Add(lbPayMode);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 107);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 107);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(200, 100);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 72);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ImgBuy
            // 
            ImgBuy.Image = (Image)resources.GetObject("ImgBuy.Image");
            ImgBuy.Location = new Point(12, 10);
            ImgBuy.Name = "ImgBuy";
            ImgBuy.Size = new Size(109, 91);
            ImgBuy.SizeMode = PictureBoxSizeMode.Zoom;
            ImgBuy.TabIndex = 3;
            ImgBuy.TabStop = false;
            // 
            // lbPayMode
            // 
            lbPayMode.AutoSize = true;
            lbPayMode.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbPayMode.Location = new Point(127, 39);
            lbPayMode.Name = "lbPayMode";
            lbPayMode.Size = new Size(133, 33);
            lbPayMode.TabIndex = 2;
            lbPayMode.Text = "PAY MODE";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPayModeList);
            tabControl2.Controls.Add(tabPagePayModeDetail);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 107);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(800, 343);
            tabControl2.TabIndex = 1;
            // 
            // tabPayModeList
            // 
            tabPayModeList.Controls.Add(BtnClose);
            tabPayModeList.Controls.Add(BtnDelete);
            tabPayModeList.Controls.Add(BtnEdit);
            tabPayModeList.Controls.Add(BtnNew);
            tabPayModeList.Controls.Add(DgPayMode);
            tabPayModeList.Controls.Add(BtnSearch);
            tabPayModeList.Controls.Add(TxtSearch);
            tabPayModeList.Controls.Add(label1);
            tabPayModeList.Location = new Point(4, 24);
            tabPayModeList.Name = "tabPayModeList";
            tabPayModeList.Padding = new Padding(3);
            tabPayModeList.Size = new Size(792, 315);
            tabPayModeList.TabIndex = 0;
            tabPayModeList.Text = "Pay Mode List";
            tabPayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(572, 259);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(200, 48);
            BtnClose.TabIndex = 4;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.Location = new Point(572, 199);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(200, 54);
            BtnDelete.TabIndex = 4;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.Location = new Point(572, 126);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(200, 67);
            BtnEdit.TabIndex = 4;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.Location = new Point(572, 69);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(200, 51);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(18, 69);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowTemplate.Height = 25;
            DgPayMode.Size = new Size(548, 238);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = (Image)resources.GetObject("BtnSearch.Image");
            BtnSearch.Location = new Point(526, 22);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(40, 41);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(18, 32);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(502, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Search Pay Mode";
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label2);
            tabPagePayModeDetail.Location = new Point(4, 24);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(792, 315);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(144, 246);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(96, 51);
            BtnCancel.TabIndex = 3;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(21, 246);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(96, 51);
            BtnSave.TabIndex = 3;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 140);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Observation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 75);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Pay Mode Name";
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPayModeObservation.Location = new Point(20, 158);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(329, 72);
            TxtPayModeObservation.TabIndex = 1;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPayModeName.Location = new Point(20, 93);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(329, 23);
            TxtPayModeName.TabIndex = 1;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(21, 33);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(137, 23);
            TxtPayModeId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 15);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 0;
            label2.Text = "Pay Mode id";
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl2);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "PayModeView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImgBuy).EndInit();
            tabControl2.ResumeLayout(false);
            tabPayModeList.ResumeLayout(false);
            tabPayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox ImgBuy;
        private Label lbPayMode;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private TabPage tabPayModeList;
        private TabPage tabPagePayModeDetail;
        private TextBox TxtSearch;
        private Label label1;
        private DataGridView DgPayMode;
        private Button BtnSearch;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnClose;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox TxtPayModeObservation;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeId;
        private Button BtnCancel;
        private Button BtnSave;
    }
}