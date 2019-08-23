using System;
using System.Collections.Generic;
using System.Text;
using AppCualquiera82219.Model;

namespace AppCualquiera82219.Sevices
{
    public interface IRepositoryProduct
    {
        void AddNewProduct(Model.ProductoModel newProduct);

        List<Model.ProductoModel> Get();

        bool UpdateProduct(ProductoModel UpdatetoProduct);
    }
}
