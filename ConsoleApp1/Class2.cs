using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class klient
    {
        public int id_klient { get; set; }

        public string email { get; set; }

        public int phone_number { get; set; }

        public string adress { get; set; }

    }

}
