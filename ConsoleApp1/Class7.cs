using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{

    public class Tovar
    {
        public string id_product { get; set; }

        public string name { get; set; }

        public decimal? price { get; set; }

        public TimeSpan? delivery_time { get; set; }

    }

}
