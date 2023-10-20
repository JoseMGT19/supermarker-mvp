using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface ICategorieRepository
    {
        void Add(CategoriesModel categorieMode);
        void Edit(CategoriesModel categorieMode);
        void Delete(int id);
        IEnumerable<CategoriesModel> GetAll();  
        IEnumerable<CategoriesModel> GetByValue(string value);

    }
}
