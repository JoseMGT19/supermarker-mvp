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
            tabProducts = new TabControl();
            tabProductsList = new TabPage();
            BtnClosed = new Button();
            BtnDeleteP = new Button();
            BtnEditP = new Button();
            BtnNewP = new Button();
            DgProduct = new DataGridView();
            BtnSearchP = new Button();
            TxtSearchS = new TextBox();
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
            tabProducts.SuspendLayout();
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
            // tabProducts
            // 
            tabProducts.Controls.Add(tabProductsList);
            tabProducts.Controls.Add(tabProductsDetail);
            tabProducts.Dock = DockStyle.Fill;
            tabProducts.Location = new Point(0, 100);
            tabProducts.Name = "tabProducts";
            tabProducts.SelectedIndex = 0;
            tabProducts.Size = new Size(800, 350);
            tabProducts.TabIndex = 3;
            // 
            // tabProductsList
            // 
            tabProductsList.Controls.Add(BtnClosed);
            tabProductsList.Controls.Add(BtnDeleteP);
            tabProductsList.Controls.Add(BtnEditP);
            tabProductsList.Controls.Add(BtnNewP);
            tabProductsList.Controls.Add(DgProduct);
            tabProductsList.Controls.Add(BtnSearchP);
            tabProductsList.Controls.Add(TxtSearchS);
            tabProductsList.Controls.Add(lbSearch);
            tabProductsList.Location = new Point(4, 24);
            tabProductsList.Name = "tabProductsList";
            tabProductsList.Padding = new Padding(3);
            tabProductsList.Size = new Size(792, 322);
            tabProductsList.TabIndex = 0;
            tabProductsList.Text = "Products List";
            tabProductsList.UseVisualStyleBackColor = true;
            // 
            // BtnClosed
            // 
            BtnClosed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClosed.Image = Properties.Resources.cerrar;
            BtnClosed.Location = new Point(622, 267);
            BtnClosed.Name = "BtnClosed";
            BtnClosed.Size = new Size(162, 47);
            BtnClosed.TabIndex = 4;
            BtnClosed.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteP
            // 
            BtnDeleteP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteP.Image = Properties.Resources.delete;
            BtnDeleteP.Location = new Point(622, 203);
            BtnDeleteP.Name = "BtnDeleteP";
            BtnDeleteP.Size = new Size(162, 47);
            BtnDeleteP.TabIndex = 4;
            BtnDeleteP.UseVisualStyleBackColor = true;
            // 
            // BtnEditP
            // 
            BtnEditP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditP.Image = Properties.Resources.edit;
            BtnEditP.Location = new Point(622, 139);
            BtnEditP.Name = "BtnEditP";
            BtnEditP.Size = new Size(162, 47);
            BtnEditP.TabIndex = 4;
            BtnEditP.UseVisualStyleBackColor = true;
            // 
            // BtnNewP
            // 
            BtnNewP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewP.BackColor = Color.Transparent;
            BtnNewP.Image = Properties.Resources._new;
            BtnNewP.Location = new Point(622, 73);
            BtnNewP.Name = "BtnNewP";
            BtnNewP.Size = new Size(162, 47);
            BtnNewP.TabIndex = 4;
            BtnNewP.UseVisualStyleBackColor = false;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(22, 73);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.RowTemplate.Height = 25;
            DgProduct.Size = new Size(594, 241);
            DgProduct.TabIndex = 3;
            // 
            // BtnSearchP
            // 
            BtnSearchP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchP.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearchP.Image = Properties.Resources.search_small;
            BtnSearchP.Location = new Point(566, 21);
            BtnSearchP.Name = "BtnSearchP";
            BtnSearchP.Size = new Size(50, 46);
            BtnSearchP.TabIndex = 2;
            BtnSearchP.UseVisualStyleBackColor = true;
            // 
            // TxtSearchS
            // 
            TxtSearchS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearchS.Location = new Point(22, 35);
            TxtSearchS.Name = "TxtSearchS";
            TxtSearchS.PlaceholderText = "Data to search";
            TxtSearchS.Size = new Size(538, 23);
            TxtSearchS.TabIndex = 1;
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
            Controls.Add(tabProducts);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabProducts.ResumeLayout(false);
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
        private TabControl tabProducts;
        private TabPage tabProductsList;
        private Button BtnClosed;
        private Button BtnDeleteP;
        private Button BtnEditP;
        private Button BtnNewP;
        private DataGridView DgProduct;
        private Button BtnSearchP;
        private TextBox TxtSearchS;
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