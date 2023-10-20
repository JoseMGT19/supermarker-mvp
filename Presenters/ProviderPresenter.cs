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

        public ProviderPresenter(IProviderView view, IProviderRepository repository)
        {
            this.providerBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProvider;
            this.view.AddNewEvent += AddNewProvider;
            this.view.EditEvent += LoadSelectProviderToEdit;
            this.view.DeleteEvent += DelecteSelectedProvider;
            this.view.SaveEvent += SaveProvider;
            this.view.CancelEvent += CancelAction;

            this.view.SetProviderListBildingSource(providerBindingSource);
            loadAllProviderList();
            this.view.Show();
        }

        private void loadAllProviderList()
        {
            providerList = repository.GetAll();
            providerBindingSource.DataSource = providerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProvider(object? sender, EventArgs e)
        {
            var provideMode = new ProvidersModel();
            provideMode.Id = Convert.ToInt32(view.ProviderId);
            provideMode.Name = view.ProviderName;
            provideMode.Observation = view.ProviderObservation;

            try
            {
                new Common.ModelDataValidation().Validate(provideMode);
                if (view.IsEdit)
                {
                    repository.Edit(provideMode);
                    view.Message = "Provider edited successfuly";
                }
                else
                {
                    repository.Add(provideMode);
                    view.Message = "Provider added successfuly";
                }
                view.IsSuccessful = true;
                loadAllProviderList();
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
            view.ProviderId = "0";
            view.ProviderName = "";
            view.ProviderObservation = "";
        }

        private void DelecteSelectedProvider(object? sender, EventArgs e)
        {
            try
            {
                var provideMode = (ProvidersModel)providerBindingSource.Current;

                repository.Delete(provideMode.Id);
                view.IsSuccessful = true;
                view.Message = "Provider deleted successfully";
                loadAllProviderList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ah error ocurred, could not delete provider";
            }
        }

        private void LoadSelectProviderToEdit(object? sender, EventArgs e)
        {
            //Se obtiene el objeto del dtagridview que se encuentra seleccionado
            var provideMode = (ProvidersModel)providerBindingSource.Current;
            //Se cambia el contenido de las cajas de texto por el objeto recuperado 
            // del datagrudview
            view.ProviderId = provideMode.Id.ToString();
            view.ProviderName = provideMode.Name;
            view.ProviderObservation = provideMode.Observation;

            //Se establece el modo como edicion
            view.IsEdit = true;
        }

        private void AddNewProvider(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProvider(object? sender, EventArgs e)
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
        }
    }
