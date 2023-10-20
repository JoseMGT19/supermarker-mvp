namespace Supermarket_mvp.Views
{
    partial class CategoriesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesView));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabCategoriesList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCategories = new DataGridView();
            BtnSearchP = new Button();
            TxtSearchs = new TextBox();
            lbSearch = new Label();
            tabCategoriesDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            TxtCategoriesObservation = new TextBox();
            TxtCategoriesName = new TextBox();
            TxtCategoriesId = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabCategoriesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            tabCategoriesDetail.SuspendLayout();
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
            label1.Size = new Size(156, 32);
            label1.TabIndex = 5;
            label1.Text = "CATEGORIES";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCategoriesList);
            tabControl1.Controls.Add(tabCategoriesDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 2;
            // 
            // tabCategoriesList
            // 
            tabCategoriesList.Controls.Add(BtnClose);
            tabCategoriesList.Controls.Add(BtnDelete);
            tabCategoriesList.Controls.Add(BtnEdit);
            tabCategoriesList.Controls.Add(BtnNew);
            tabCategoriesList.Controls.Add(DgCategories);
            tabCategoriesList.Controls.Add(BtnSearchP);
            tabCategoriesList.Controls.Add(TxtSearchs);
            tabCategoriesList.Controls.Add(lbSearch);
            tabCategoriesList.Location = new Point(4, 24);
            tabCategoriesList.Name = "tabCategoriesList";
            tabCategoriesList.Padding = new Padding(3);
            tabCategoriesList.Size = new Size(792, 322);
            tabCategoriesList.TabIndex = 0;
            tabCategoriesList.Text = "Categories List";
            tabCategoriesList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(615, 264);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(162, 47);
            BtnClose.TabIndex = 17;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(615, 200);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(162, 47);
            BtnDelete.TabIndex = 18;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(615, 136);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(162, 47);
            BtnEdit.TabIndex = 19;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.BackColor = Color.Transparent;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(615, 70);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(162, 47);
            BtnNew.TabIndex = 20;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // DgCategories
            // 
            DgCategories.AllowUserToAddRows = false;
            DgCategories.AllowUserToDeleteRows = false;
            DgCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Location = new Point(15, 70);
            DgCategories.Name = "DgCategories";
            DgCategories.ReadOnly = true;
            DgCategories.RowTemplate.Height = 25;
            DgCategories.Size = new Size(594, 241);
            DgCategories.TabIndex = 16;
            // 
            // BtnSearchP
            // 
            BtnSearchP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchP.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearchP.Image = Properties.Resources.search_small;
            BtnSearchP.Location = new Point(559, 18);
            BtnSearchP.Name = "BtnSearchP";
            BtnSearchP.Size = new Size(50, 46);
            BtnSearchP.TabIndex = 15;
            BtnSearchP.UseVisualStyleBackColor = true;
            // 
            // TxtSearchs
            // 
            TxtSearchs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearchs.Location = new Point(15, 32);
            TxtSearchs.Name = "TxtSearchs";
            TxtSearchs.PlaceholderText = "Data to search";
            TxtSearchs.Size = new Size(538, 23);
            TxtSearchs.TabIndex = 14;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbSearch.Location = new Point(8, 12);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(117, 17);
            lbSearch.TabIndex = 13;
            lbSearch.Text = "Search Categories";
            // 
            // tabCategoriesDetail
            // 
            tabCategoriesDetail.Controls.Add(BtnCancel);
            tabCategoriesDetail.Controls.Add(BtnSave);
            tabCategoriesDetail.Controls.Add(label4);
            tabCategoriesDetail.Controls.Add(label3);
            tabCategoriesDetail.Controls.Add(TxtCategoriesObservation);
            tabCategoriesDetail.Controls.Add(TxtCategoriesName);
            tabCategoriesDetail.Controls.Add(TxtCategoriesId);
            tabCategoriesDetail.Controls.Add(label2);
            tabCategoriesDetail.Location = new Point(4, 24);
            tabCategoriesDetail.Name = "tabCategoriesDetail";
            tabCategoriesDetail.Padding = new Padding(3);
            tabCategoriesDetail.Size = new Size(792, 322);
            tabCategoriesDetail.TabIndex = 1;
            tabCategoriesDetail.Text = "Categories Detail";
            tabCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(148, 252);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(96, 51);
            BtnCancel.TabIndex = 18;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(25, 252);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(96, 51);
            BtnSave.TabIndex = 19;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 149);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 16;
            label4.Text = "Categories Observation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 84);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 17;
            label3.Text = "Categories Name";
            // 
            // TxtCategoriesObservation
            // 
            TxtCategoriesObservation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCategoriesObservation.Location = new Point(24, 164);
            TxtCategoriesObservation.Multiline = true;
            TxtCategoriesObservation.Name = "TxtCategoriesObservation";
            TxtCategoriesObservation.PlaceholderText = "Categories Observation";
            TxtCategoriesObservation.Size = new Size(329, 72);
            TxtCategoriesObservation.TabIndex = 13;
            // 
            // TxtCategoriesName
            // 
            TxtCategoriesName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCategoriesName.Location = new Point(24, 99);
            TxtCategoriesName.Name = "TxtCategoriesName";
            TxtCategoriesName.PlaceholderText = "Categories Name";
            TxtCategoriesName.Size = new Size(329, 23);
            TxtCategoriesName.TabIndex = 14;
            // 
            // TxtCategoriesId
            // 
            TxtCategoriesId.Location = new Point(25, 39);
            TxtCategoriesId.Name = "TxtCategoriesId";
            TxtCategoriesId.Size = new Size(137, 23);
            TxtCategoriesId.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 24);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 12;
            label2.Text = "Categories id";
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "CategoriesView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabCategoriesList.ResumeLayout(false);
            tabCategoriesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            tabCategoriesDetail.ResumeLayout(false);
            tabCategoriesDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabCategoriesList;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCategories;
        private Button BtnSearchP;
        private TextBox TxtSearchs;
        private Label lbSearch;
        private TabPage tabCategoriesDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private Label label4;
        private Label label3;
        private TextBox TxtCategoriesObservation;
        private TextBox TxtCategoriesName;
        private TextBox TxtCategoriesId;
        private Label label2;
    }
}