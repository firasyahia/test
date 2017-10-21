using Ski.Domain.Entity;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski.Service
{
    public interface IProductService : IService<Product>
    {
        //je crée cette interface méme si je n'ai pas des méthodes supplémentaire ou spécifique

        IEnumerable<Product> GetPGetProductsLastYearByCategory(string nameCat);
    }
}
