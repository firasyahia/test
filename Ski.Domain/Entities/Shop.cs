using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski.Domain.Entities
{
    public class Shop
    {
        //pas d'id dans un complex type
        public int IdAd { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public int SignalNumber { get; set; }
        public int IdUser { get; set; }

    }
}
