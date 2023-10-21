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
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
            BtnProduct.Click += delegate { showProductView?.Invoke(this, EventArgs.Empty); };
            BtnProvider.Click += delegate { showProvidersView?.Invoke(this, EventArgs.Empty); };
            BtnCategories.Click += delegate { ShowCategoriesView?.Invoke(this, EventArgs.Empty); };

            BtnExit.Click += delegate { this.Close(); };
        }

        public event EventHandler ShowPayModeView;
        public event EventHandler showProductView;

        public event EventHandler ShowCategoriesView;
        public event EventHandler showProvidersView;
    }
}
