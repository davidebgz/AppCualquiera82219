﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppCualquiera82219.Model
{
    [Table("Products")]
    public class ProductoModel
    {
        [PrimaryKey, Unique]
        public int Id{ get; set; }
        public string NameProduct{ get; set; }
        public decimal Price { get; set; }
        public int unit { get; set; }
        
    }
}
