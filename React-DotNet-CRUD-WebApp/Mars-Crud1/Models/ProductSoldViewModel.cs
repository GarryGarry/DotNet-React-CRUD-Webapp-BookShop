using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mars_Crud1.Models
{
    public class ProductSoldViewModel
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public int? StoreId { get; set; }
        public string CName { get; set; }
        public string PName { get; set; }
        public string SName { get; set; }

        public String DateSold { get; set; }

        public List<CustomerViewModel> Customer { get; set; }
        public List<ProductViewModel> Product { get; set; }
        public List<StoreViewModel> Store { get; set; }
    }
}