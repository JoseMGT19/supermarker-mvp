namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            tabProductsList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProduct = new DataGridView();
            BtnSearchP = new Button();
            TxtSearchs = new TextBox();
            lbSearch = new Label();
            tabProductsDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProductObservation = new TextBox();
            label3 = new Label();
            TxtProductName = new TextBox();
            label2 = new Label();
            TxtProductId = new TextBox();
            lblProduct = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabProductsDetail.SuspendLayout();
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
            label1.Location = new Point(135, 34);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 3;
            label1.Text = "Products";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProductsList);
            tabControl1.Controls.Add(tabProductsDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 3;
            // 
            // tabProductsList
            // 
            tabProductsList.Controls.Add(BtnClose);
            tabProductsList.Controls.Add(BtnDelete);
            tabProductsList.Controls.Add(BtnEdit);
            tabProductsList.Controls.Add(BtnNew);
            tabProductsList.Controls.Add(DgProduct);
            tabProductsList.Controls.Add(BtnSearchP);
            tabProductsList.Controls.Add(TxtSearchs);
            tabProductsList.Controls.Add(lbSearch);
            tabProductsList.Location = new Point(4, 24);
            tabProductsList.Name = "tabProductsList";
            tabProductsList.Padding = new Padding(3);
            tabProductsList.Size = new Size(792, 322);
            tabProductsList.TabIndex = 0;
            tabProductsList.Text = "Products List";
            tabProductsList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(622, 267);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(162, 47);
            BtnClose.TabIndex = 4;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(622, 203);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(162, 47);
            BtnDelete.TabIndex = 4;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(622, 139);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(162, 47);
            BtnEdit.TabIndex = 4;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.BackColor = Color.Transparent;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(622, 73);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(162, 47);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // DgProduct
            // 
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(22, 73);
            DgProduct.Name = "DgProduct";
            DgProduct.RowTemplate.Height = 25;
            DgProduct.Size = new Size(594, 241);
            DgProduct.TabIndex = 3;
            // 
            // BtnSearchP
            // 
            BtnSearchP.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearchP.Image = Properties.Resources.search_small;
            BtnSearchP.Location = new Point(566, 21);
            BtnSearchP.Name = "BtnSearchP";
            BtnSearchP.Size = new Size(50, 46);
            BtnSearchP.TabIndex = 2;
            BtnSearchP.UseVisualStyleBackColor = true;
            // 
            // TxtSearchs
            // 
            TxtSearchs.Location = new Point(22, 35);
            TxtSearchs.Name = "TxtSearchs";
            TxtSearchs.PlaceholderText = "Data to search";
            TxtSearchs.Size = new Size(538, 23);
            TxtSearchs.TabIndex = 1;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbSearch.Location = new Point(25, 18);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(106, 17);
            lbSearch.TabIndex = 0;
            lbSearch.Text = "Search Products";
            // 
            // tabProductsDetail
            // 
            tabProductsDetail.Controls.Add(BtnCancel);
            tabProductsDetail.Controls.Add(BtnSave);
            tabProductsDetail.Controls.Add(TxtProductObservation);
            tabProductsDetail.Controls.Add(label3);
            tabProductsDetail.Controls.Add(TxtProductName);
            tabProductsDetail.Controls.Add(label2);
            tabProductsDetail.Controls.Add(TxtProductId);
            tabProductsDetail.Controls.Add(lblProduct);
            tabProductsDetail.Location = new Point(4, 24);
            tabProductsDetail.Name = "tabProductsDetail";
            tabProductsDetail.Padding = new Padding(3);
            tabProductsDetail.Size = new Size(792, 322);
            tabProductsDetail.TabIndex = 1;
            tabProductsDetail.Text = "Products Detail";
            tabProductsDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(190, 260);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(126, 54);
            BtnCancel.TabIndex = 2;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSave.ForeColor = SystemColors.ControlText;
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(33, 260);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(126, 54);
            BtnSave.TabIndex = 2;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductObservation
            // 
            TxtProductObservation.Location = new Point(33, 170);
            TxtProductObservation.Multiline = true;
            TxtProductObservation.Name = "TxtProductObservation";
            TxtProductObservation.PlaceholderText = "Product Observation";
            TxtProductObservation.Size = new Size(377, 74);
            TxtProductObservation.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 153);
            label3.Name = "label3";
            label3.Size = new Size(136, 17);
            label3.TabIndex = 0;
            label3.Text = "Product Observation";
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(33, 106);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "Product Name";
            TxtProductName.Size = new Size(377, 23);
            TxtProductName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 86);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 0;
            label2.Text = "Product Name";
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(33, 39);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(159, 23);
            TxtProductId.TabIndex = 1;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduct.Location = new Point(36, 22);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(72, 17);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Product Id";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabProductsList.ResumeLayout(false);
            tabProductsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabProductsDetail.ResumeLayout(false);
            tabProductsDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabProductsList;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProduct;
        private Button BtnSearchP;
        private TextBox TxtSearchs;
        private Label lbSearch;
        private TabPage tabProductsDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductObservation;
        private Label label3;
        private TextBox TxtProductName;
        private Label label2;
        private TextBox TxtProductId;
        private Label lblProduct;
    }
}