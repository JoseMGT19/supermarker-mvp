using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class ProvidersView : Form, IProviderView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProvidersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabProviderDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearchP.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            BtnNew.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty); };
            tabControl1.TabPages.Add(tabProviderDetail);
            tabControl1.TabPages.Remove(tabProvidersList);
            tabProviderDetail.Text = "Add New Provider";

            BtnEdit.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };
            tabControl1.TabPages.Remove(tabProvidersList);
            tabControl1.TabPages.Add(tabProviderDetail);
            tabProviderDetail.Text = "Edit Provider";
        }

        public string ProviderId
        {
            get { return TxtProvidersId.Text; }
            set { TxtProvidersId.Text = value; }
        }
        public string ProviderName
        {
            get { return TxtProvidersName.Text; }
            set { TxtProvidersName.Text = value; }
        }
        public string ProviderObservation
        {
            get { return TxtProvidersObservation.Text; }
            set { TxtProvidersObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProviderListBildingSource(BindingSource providerList)
        {
            DgProvider.DataSource = providerList;
        }
    }
}
