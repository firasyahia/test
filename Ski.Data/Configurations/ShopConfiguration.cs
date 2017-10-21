using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ski.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Ski.Data.Configurations
{
    public class ShopConfiguration : ComplexTypeConfiguration<Shop>
    {
        public ShopConfiguration()
        {

            Property(a => a.Title).IsRequired().HasMaxLength(25);
            Property(a => a.Description).IsRequired();
            Property(a => a.Picture).IsOptional();
            Property(a => a.Type).IsRequired();
            Property(a => a.Price).IsRequired();
            Property(a => a.IdUser).IsRequired();

        }
    }
}
