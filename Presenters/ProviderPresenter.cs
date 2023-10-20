using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class ProviderPresenter
    {
        private IProviderView view;
        private IProviderRepository repository;
        private BindingSource providerBindingSource;
        private IEnumerable<ProvidersModel> providerList;

        public ProviderPresenter(IProviderView view, IProviderRepository repository, BindingSource providerBindingSource, IEnumerable<ProvidersModel> providerList)
        {
            this.providerBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.DeleteEvent += DelecteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProviderListBildingSource(providerBindingSource);
            loadAllProductList();
            this.view.Show();
        }

        private void loadAllProductList()
        {
            providerList = repository.GetAll();
            providerBindingSource.DataSource = providerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DelecteSelectedProduct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providerList = repository.GetAll();
            }
            providerBindingSource.DataSource = providerList;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
