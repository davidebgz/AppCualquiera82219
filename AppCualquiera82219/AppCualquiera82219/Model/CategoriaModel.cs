using System;
using System.Collections.Generic;
using System.Text;

namespace AppCualquiera82219.Model
{
    public class CategoriaModel
    {
        public int Id { get; set; }
        public int CategoryName { get; set; }
        public int Description { get; set; }
        public List<ProductoModel> Products { get; set; }
    }
}
