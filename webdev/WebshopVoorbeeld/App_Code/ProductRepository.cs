using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.WebPages;
using WebMatrix.Data;

/// <summary>
/// Summary description for ProductRepository
/// </summary>
public class ProductRepository
{
    public static List<Product> SelectAll()
    {
        List<Product> products = new List<Product>();

        Database db = Database.Open("ProductDb");
        var rows = db.Query("SELECT ProductId, CategoryId, Name, Price FROM Product");
        foreach (var row in rows)
        {
            products.Add(new Product(row.ProductId, row.CategoryId, row.Name, row.Price));
        }

        db.Close();

        return products;
    } 

    public static Product SelectProductsById(int productId)
    {
        Database db = Database.Open("ProductDb");
        var row = db.QuerySingle("SELECT ProductId, CategoryId, Name, Price FROM Product WHERE ProductId = @0",
            productId);

        if (row == null)
        {
            db.Close();
            return null;
        }

        Product p = new Product(row.ProductId, row.CategoryId, row.Name, row.Price);
        db.Close();
        return p;
    }

    public static List<Product> SelectProductsByCategoryId(int categoryId)
    {
        List<Product> result = new List<Product>();

        Database db = Database.Open("ProductDb");
        var rows = db.Query("SELECT ProductId, CategoryId, Name, Price FROM Product WHERE CategoryId = @0", categoryId);
        foreach (var row in rows)
        {
            result.Add(new Product(row.ProductId, row.CategoryId, row.Name, row.Price));
        }
        db.Close();

        return result;
    }

    public static int Insert(Product product)
    {
        Database db = Database.Open("ProductDb");
        int numRowsEffected = db.Execute("INSERT INTO Product (Name, Price, CategoryId) VALUES (@0, @1, @2)",
            product.Name, product.Price, product.CategoryId);

        int result = -1;
        if (numRowsEffected == 1)
        {
            result = Convert.ToInt32(db.GetLastInsertId());
        }

        db.Close();

        return result;
    }

    public static bool Delete(int productId)
    {
        Database db = Database.Open("ProductDb");
        int numRowsEffected = db.Execute("DELETE FROM Product WHERE productId = @0",
            productId);
        db.Close();
        return numRowsEffected == 1;
    }

    public static int InsertByForm(WebPage page)
    {
        if (page.IsPost)
        {
            page.Validation.RequireField("name", "naam mag niet leeg zijn");
            page.Validation.Add("name", Validator.StringLength(
                maxLength: 50, minLength: 3,
                errorMessage: "naam moet tussen 3 en 50 tekens bevatten"));

            page.Validation.RequireField("price", "prijs mag niet leeg zijn");
            page.Validation.Add("price", Validator.Decimal("prijs moet een decimal zijn"));

            page.Validation.RequireField("categoryId", "category moet gekozen zijn");

            if (page.Validation.IsValid())
            {
                string name = page.Request.Form["name"];
                decimal price = page.Request.Form["price"].AsDecimal();
                int categoryId = page.Request.Form["categoryId"].AsInt();

                Product product = new Product() { };
                product.Name = name;
                product.Price = price;
                product.CategoryId = categoryId;
                return ProductRepository.Insert(product);
            }
            else
            {
                return -1;
            }
        }
        return -1;
    }

    public static List<Product> SelectAllWithCategory()
    {
        string sql = @"SELECT ProductId, p.Name as pName, Price, c.CategoryId, c.Name as cName
                            FROM Product p JOIN Category c ON
                                p.CategoryId = c.CategoryId
                        ORDER BY p.Name";

        List<Product> products = new List<Product>();
        Database db = Database.Open("ProductDb");

        Dictionary<int, Category> categories = new Dictionary<int, Category>();

        foreach (var row in db.Query(sql))
        {
            Product p = new Product(row.ProductId, row.CategoryId, row.pName, row.Price);

            if (!categories.ContainsKey(row.CategoryId))
            {
                Category cat = new Category(row.CategoryId, row.cName);
                cat.Products = new List<Product>();
                categories.Add(row.CategoryId, cat);
            }

            Category category = categories[row.CategoryId];
            category.Products.Add(p);
            p.Category = category;

            products.Add(p);
        }
        db.Close();

        return products;
    }
}