using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.DeleteEvent += DelecteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBildingSource(productBindingSource);
            loadAllProductList();
            this.view.Show();
        }

        private void loadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var productMode = new ProductModel();
            productMode.Id = Convert.ToInt32(view.ProductId);
            productMode.Name = view.ProductName;
            productMode.Observation = view.ProductObservation;

            try
            {
                new Common.ModelDataValidation().Validate(productMode);
                if (view.IsEdit)
                {
                    repository.Edit(productMode);
                    view.Message = "Product edited successfuly";
                }
                else
                {
                    repository.Add(productMode);
                    view.Message = "Product added successfuly";
                }
                view.IsSuccessful = true;
                loadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductObservation = "";
        }

        private void DelecteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                var productMode = (PayModeModel)productBindingSource.Current;

                repository.Delete(productMode.Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted successfully";
                loadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ah error ocurred, could not delete product";
            }
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            //Se obtiene el objeto del dtagridview que se encuentra seleccionado
            var productMode = (ProductModel)productBindingSource.Current;
            //Se cambia el contenido de las cajas de texto por el objeto recuperado 
            // del datagrudview
            view.ProductId = productMode.Id.ToString();
            view.ProductName = productMode.Name;
            view.ProductObservation = productMode.Observation;

            //Se establece el modo como edicion
            view.IsEdit = true;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }
    }
}
