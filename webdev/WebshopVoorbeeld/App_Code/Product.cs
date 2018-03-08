using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Helpers;
using System.Web.WebPages;
using System.Web.WebPages.Html;
using WebMatrix.Data;

public class Product
{
    public int      ProductId   { get; set; }
    public string   Name        { get; set; }
    public decimal  Price       { get; set; }
    public int      CategoryId  { get; set; }

    private Category _category;
    public Category Category
    {
        get
        {
            if (_category == null)
            {
                _category = CategoryRepository.SelectById(CategoryId);
            }
            return _category;
        }
        set { _category = value; }
    }

    public Product() {}

    public Product(int productId, int categoryId, string name, decimal price)
    {
        ProductId = productId;
        CategoryId = categoryId;
        Name = name;
        Price = price;
    }
}


