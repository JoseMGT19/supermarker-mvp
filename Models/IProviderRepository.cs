using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IProviderRepository
    {
        void Add(ProvidersModel providerModel);
        void Edit(ProvidersModel providerModel);
        void Delete(int id);
        IEnumerable<ProvidersModel> GetAll();
        IEnumerable<ProvidersModel> GetByValue(string value);
    }
}
