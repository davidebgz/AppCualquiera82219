using System;
using System.Collections.Generic;
using System.Text;
using AppCualquiera82219.Sevices;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace AppCualquiera82219.Model
{

    public class ProductRepository : IRepositoryProduct
    {
        public string MessageStatus { get; set; }
        SQLiteConnection conn;
        public ProductRepository(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<ProductoModel>();
        }

        public void AddNewProduct(ProductoModel newProduct)
        {
            try
            {
                conn.Insert(newProduct);
                MessageStatus = $"registro ingresado.Product Id: {newProduct.Id}, Name: {newProduct}";
            }
            
            catch (Exception ex)
            {
                MessageStatus = $"Error al guardar registro. Error: {ex.Message}";
            }
        }

        public List<ProductoModel> Get()
        {
            return conn.Table<ProductoModel>().ToList();
        }

        public bool UpdateProduct(ProductoModel productToUpdate)
        {
            return conn.Update(productToUpdate) > 1;
        }
    }
}
