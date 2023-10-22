using Microsoft.Data.SqlClient;
using Supermarket_mvp._Repositories;
using Supermarket_mvp.Models;
using Supermarket_mvp.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Supermarket_mvp.Views
{
    public partial class ProductView : Form, IProductView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabProducts.TabPages.Remove(tabProductsDetail);
            BtnClosed.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearchP.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearchS.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNewP.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabProducts.TabPages.Add(tabProductsDetail);
                tabProducts.TabPages.Remove(tabProductsList);
                tabProductsDetail.Text = "Add New Product";
            };

            BtnEditP.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabProducts.TabPages.Remove(tabProductsList);
                tabProducts.TabPages.Add(tabProductsDetail);
                tabProductsDetail.Text = "Edit Product";
            };

            BtnDeleteP.Click += delegate
            {
                var result = MessageBox.Show(
                "Are you sure you want to delete the selected Product",
                "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabProducts.TabPages.Remove(tabProductsDetail);
                    tabProducts.TabPages.Add(tabProductsList);
                }
                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabProducts.TabPages.Remove(tabProductsDetail);
                tabProducts.TabPages.Add(tabProductsList);
            };

        }



        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;



        public string ProductId
        {
            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }
        }
        public string ProdcutsName
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }
        }
        public string ProductObservation
        {
            get { return TxtProductObservation.Text; }
            set { TxtProductObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearchS.Text; }
            set { TxtSearchS.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { IsSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        string IProductView.ProductName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private static ProductView instance;

        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        

        public void SetProductListBildingSource(BindingSource productList)
        {
            DgProduct.DataSource = productList;
        }
    }


}

