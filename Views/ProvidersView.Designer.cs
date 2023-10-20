namespace Supermarket_mvp.Views
{
    partial class ProvidersView
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabProvidersList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProvider = new DataGridView();
            BtnSearchP = new Button();
            TxtSearch = new TextBox();
            lbSearch = new Label();
            tabProviderDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            TxtProvidersObservation = new TextBox();
            TxtProvidersName = new TextBox();
            TxtProvidersId = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabProvidersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).BeginInit();
            tabProviderDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 37);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 3;
            label1.Text = "PROVIDERS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProvidersList);
            tabControl1.Controls.Add(tabProviderDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 2;
            // 
            // tabProvidersList
            // 
            tabProvidersList.Controls.Add(BtnClose);
            tabProvidersList.Controls.Add(BtnDelete);
            tabProvidersList.Controls.Add(BtnEdit);
            tabProvidersList.Controls.Add(BtnNew);
            tabProvidersList.Controls.Add(DgProvider);
            tabProvidersList.Controls.Add(BtnSearchP);
            tabProvidersList.Controls.Add(TxtSearch);
            tabProvidersList.Controls.Add(lbSearch);
            tabProvidersList.Location = new Point(4, 24);
            tabProvidersList.Name = "tabProvidersList";
            tabProvidersList.Padding = new Padding(3);
            tabProvidersList.Size = new Size(792, 322);
            tabProvidersList.TabIndex = 0;
            tabProvidersList.Text = "Providers List";
            tabProvidersList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(615, 264);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(162, 47);
            BtnClose.TabIndex = 9;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(615, 200);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(162, 47);
            BtnDelete.TabIndex = 10;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(615, 136);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(162, 47);
            BtnEdit.TabIndex = 11;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.BackColor = Color.Transparent;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(615, 70);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(162, 47);
            BtnNew.TabIndex = 12;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // DgProvider
            // 
            DgProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProvider.Location = new Point(15, 70);
            DgProvider.Name = "DgProvider";
            DgProvider.RowTemplate.Height = 25;
            DgProvider.Size = new Size(594, 241);
            DgProvider.TabIndex = 8;
            // 
            // BtnSearchP
            // 
            BtnSearchP.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearchP.Image = Properties.Resources.search_small;
            BtnSearchP.Location = new Point(559, 18);
            BtnSearchP.Name = "BtnSearchP";
            BtnSearchP.Size = new Size(50, 46);
            BtnSearchP.TabIndex = 7;
            BtnSearchP.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(15, 32);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(538, 23);
            TxtSearch.TabIndex = 6;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbSearch.Location = new Point(15, 12);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(110, 17);
            lbSearch.TabIndex = 5;
            lbSearch.Text = "Search Providers";
            // 
            // tabProviderDetail
            // 
            tabProviderDetail.Controls.Add(BtnCancel);
            tabProviderDetail.Controls.Add(BtnSave);
            tabProviderDetail.Controls.Add(label4);
            tabProviderDetail.Controls.Add(label3);
            tabProviderDetail.Controls.Add(TxtProvidersObservation);
            tabProviderDetail.Controls.Add(TxtProvidersName);
            tabProviderDetail.Controls.Add(TxtProvidersId);
            tabProviderDetail.Controls.Add(label2);
            tabProviderDetail.Location = new Point(4, 24);
            tabProviderDetail.Name = "tabProviderDetail";
            tabProviderDetail.Padding = new Padding(3);
            tabProviderDetail.Size = new Size(792, 322);
            tabProviderDetail.TabIndex = 1;
            tabProviderDetail.Text = "Providers Detail";
            tabProviderDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(148, 252);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(96, 51);
            BtnCancel.TabIndex = 10;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(25, 252);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(96, 51);
            BtnSave.TabIndex = 11;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 146);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 8;
            label4.Text = "Providers Observation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 84);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 9;
            label3.Text = "Providers Name";
            // 
            // TxtProvidersObservation
            // 
            TxtProvidersObservation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TxtProvidersObservation.Location = new Point(24, 164);
            TxtProvidersObservation.Multiline = true;
            TxtProvidersObservation.Name = "TxtProvidersObservation";
            TxtProvidersObservation.PlaceholderText = "Providers Observation";
            TxtProvidersObservation.Size = new Size(329, 72);
            TxtProvidersObservation.TabIndex = 5;
            // 
            // TxtProvidersName
            // 
            TxtProvidersName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TxtProvidersName.Location = new Point(27, 102);
            TxtProvidersName.Name = "TxtProvidersName";
            TxtProvidersName.PlaceholderText = "Providers Name";
            TxtProvidersName.Size = new Size(329, 23);
            TxtProvidersName.TabIndex = 6;
            // 
            // TxtProvidersId
            // 
            TxtProvidersId.Location = new Point(25, 39);
            TxtProvidersId.Name = "TxtProvidersId";
            TxtProvidersId.Size = new Size(137, 23);
            TxtProvidersId.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 21);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 4;
            label2.Text = "Providers id";
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProvidersView";
            Text = "Providers View";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabProvidersList.ResumeLayout(false);
            tabProvidersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).EndInit();
            tabProviderDetail.ResumeLayout(false);
            tabProviderDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabProvidersList;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProvider;
        private Button BtnSearchP;
        private TextBox TxtSearch;
        private Label lbSearch;
        private TabPage tabProviderDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private Label label4;
        private Label label3;
        private TextBox TxtProvidersObservation;
        private TextBox TxtProvidersName;
        private TextBox TxtProvidersId;
        private Label label2;
    }
}