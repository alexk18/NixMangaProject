using System;
using DataLayer;

public class ProductRepository
{
       public List<Product> productlist = new List<Product>()
       {
            new Product(1, "Test", "DESC", 10, 5),
            new Product(2, "Test", "DESC", 20, 5),
            new Product(3, "Test", "DESC", 15, 5)
       };
};

