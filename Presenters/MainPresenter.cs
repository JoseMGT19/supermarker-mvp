﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.showProductView += showProductView;
            this.mainView.showProvidersView += showProviderView;
            this.mainView.ShowCategoriesView += showCategoriesView;
        }

        private void showCategoriesView(object? sender, EventArgs e)
        {
            ICategorieView view = CategoriesView.GetInstance((MainView)mainView);
            ICategorieRepository repository = new CategorieRepository(sqlConnectionString);
            new CategoriePresenter(view, repository);
        }

        private void showProviderView(object? sender, EventArgs e)
        {
            IProviderView view = ProvidersView.GetInstance((MainView)mainView);
            IProviderRepository repository = new ProviderRepository(sqlConnectionString);
            new ProviderPresenter(view, repository);

        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModelView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }
        private void showProductView(object? sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);

        }
    }
}
