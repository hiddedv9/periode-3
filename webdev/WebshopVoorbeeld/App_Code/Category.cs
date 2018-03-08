using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

/// <summary>
/// Summary description for Category
/// </summary>
public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; }

    private List<Product> _products; 
    public List<Product> Products
    {
        get
        {
            if (_products == null)
            {
                _products = ProductRepository.SelectProductsByCategoryId(CategoryId);
            }
            return _products;
        }
        set { _products = value; }
    }

    public Category(int categoryId, string name)
    {
        CategoryId = categoryId;
        Name = name;
    }
}