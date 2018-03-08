using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ShoppingCart
/// </summary>
public class ShoppingCart
{
    public List<Product> Products { get; set; }

	public ShoppingCart()
	{
        Products = new List<Product>();
    }
            
    public void AddProduct(int productId) {
        Product product = ProductRepository.SelectProductsById(productId);
        Products.Add(product);
    }

    public void RemoveProduct(int productId)
    {
        for (int i = 0; i < Products.Count; i++)
        {
            if (Products[i].ProductId == productId)
            {
                Products.RemoveAt(i);
                break;
            }
        }
    }
}