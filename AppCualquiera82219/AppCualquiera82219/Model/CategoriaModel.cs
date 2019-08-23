using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;

namespace AppCualquiera82219.Model
{
    public class CategoriaModel
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        [MaxLength(100)]
        public int CategoryName { get; set; }
        public int Description { get; set; }
        [OneToMany(CascadeOperations =CascadeOperation.CascadeInsert)]
        public List<ProductoModel> Products { get; set; }
    }
}
