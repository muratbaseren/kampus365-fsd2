using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Product
    {
        [Column("Ürün Adı")]
        public string Name { get; set; }

        [Column("Ürün Fiyatı")]
        public decimal Price { get; set; }
    }
}
