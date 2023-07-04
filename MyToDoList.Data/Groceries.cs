using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyToDoList.Data
{
    public class Groceries
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int GroceriesId { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Product Price")]
        [DataType(DataType.Currency)]
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
        public string Username { get; set; }
        [DataType(DataType.Currency)]
        public double TotalPrice { get; set; }

    }
}
