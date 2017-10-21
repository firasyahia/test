using Ski.Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ski.Domain.Entity;
using System.Linq.Expressions;
using Service.Pattern;

namespace Ski.Service
{
    public class ProductService : Service<Product>, IProductService
    {
        //on instancie toujours dans la couche suppérieur
        private static DataBaseFactory dbf = new DataBaseFactory();
        private static UnitOfWork utw = new UnitOfWork(dbf);
        public ProductService() : base(utw) { }


        public IEnumerable<Product> GetPGetProductsLastYearByCategory(string nameCat)
        {
            int thisYear = DateTime.Now.Year;
            return utw.GetRepository<Product>().GetMany().Where(p=>p.Category.Name.Equals(nameCat)).Where(p =>p.DateProd.Year==(thisYear-1));
        }
    }
    }
