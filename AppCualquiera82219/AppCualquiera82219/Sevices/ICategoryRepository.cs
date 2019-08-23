using System;
using System.Collections.Generic;
using System.Text;
using AppCualquiera82219.Model;

namespace AppCualquiera82219.Sevices
{
    public interface ICategoryRepository
    {
        void AddNewCategory();

        List<CategoriaModel> GetCategories();
    }
}
