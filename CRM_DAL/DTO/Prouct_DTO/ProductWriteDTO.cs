using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DAL.DTO.Prouct_DTO
{
    public class ProductWriteDTO
    {
        public string Names { get; set; }

        public int Stock { get; set; }

        public string? Descriptions { get; set; }

        public decimal SalePrices { get; set; }

        public decimal Prices { get; set; }
    }
}
