using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class CategoriePresenter
    {
        private ICategorieView view;
        private ICategorieRepository repository;
        private BindingSource categorieBindingSource;
        private IEnumerable<CategoriesModel> categorieList;

        public CategoriePresenter(ICategorieView view, ICategorieRepository repository)
        {
            this.categorieBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategorie;
            this.view.AddNewEvent += AddNewCategorie;
            this.view.EditEvent += LoadSelectCategorieToEdit;
            this.view.DeleteEvent += DeleteSelectedCategorie;
            this.view.SaveEvent += SaveCategorie;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategorieListBildingSource(categorieBindingSource);
            loadAllCategorieList();
            this.view.Show();

        }

        private void loadAllCategorieList()
        {
            categorieList = repository.GetAll();
            categorieBindingSource.DataSource = categorieList;
        }

        private void SaveCategorie(object? sender, EventArgs e)
        {
            var categorieMode = new CategoriesModel();
            categorieMode.Id = Convert.ToInt32(view.CategorieId);
            categorieMode.Name = view.CategorieName;
            categorieMode.Observation = view.CategorieObservation;
            try
            {
                new Common.ModelDataValidation().Validate(categorieMode);
                if (view.IsEdit)
                {
                    repository.Edit(categorieMode);
                    view.Message = "Categorie edited successfuly";
                }
                else
                {
                    repository.Add(categorieMode);
                    view.Message = "Categorie added successfuly";
                }
                view.IsSuccessful = true;
                loadAllCategorieList();
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
            view.CategorieId = "0";
            view.CategorieName = "";
            view.CategorieObservation = "";
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedCategorie(object? sender, EventArgs e)
        {
            try
            {
                var categorieMode = (CategoriesModel)categorieBindingSource.Current;
                repository.Delete(categorieMode.Id);
                view.IsSuccessful = true;
                view.Message = "Categorie deleted successfuly";
                loadAllCategorieList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete categorie";
            }
        }

        private void LoadSelectCategorieToEdit(object? sender, EventArgs e)
        {
            var categorieMode = (CategoriesModel)categorieBindingSource.Current;

            view.CategorieId = categorieMode.Id.ToString();
            view.CategorieName = categorieMode.Name;
            view.CategorieObservation = categorieMode.Observation;

            view.IsEdit = true;
        }

        private void AddNewCategorie(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategorie(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categorieList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categorieList = repository.GetAll();
            }
            categorieBindingSource.DataSource = categorieList;
        }

        
    }
}
