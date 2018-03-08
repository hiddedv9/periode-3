using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

/// <summary>
/// Summary description for CategoryService
/// </summary>
public class CategoryRepository
{
    public static List<Category> SelectAll()
    {
        List<Category> result = new List<Category>();

        Database db = Database.Open("ProductDb");
        var records = db.Query("SELECT CategoryId, Name FROM Category");
        foreach (var record in records)
        {
            result.Add(new Category(record.CategoryId, record.Name));
        }
        db.Close();

        return result;
    }

    public static List<Category> SelectAllCategoriesWithProduct()
    {
        string sql = @"SELECT ProductId, p.Name as pName, Price, c.CategoryId, c.Name as cName
                            FROM Product p JOIN Category c ON
                                p.CategoryId = c.CategoryId
                        ORDER BY c.Name";
        List<Category> result = new List<Category>();
        Database db = Database.Open("ProductDb");
        int categoryId = -1;
        Category category = null;
        foreach (var row in db.Query(sql))
        {
            if (categoryId != row.CategoryId)
            {
                categoryId = row.CategoryId;
                category = new Category(categoryId, row.cName);
                category.Products = new List<Product>();

                result.Add(category);
            }
            Product product = new Product(row.ProductId, row.CategoryID, row.pName, row.Price);
            product.Category = category;
            category.Products.Add(product);
        }
        db.Close();

        return result;
    }

    public static Category SelectById(int categoryId)
    {
        Database db = Database.Open("ProductDb");
        var catRecord = db.QuerySingle("SELECT CategoryId, Name FROM Category WHERE CategoryId = @0", categoryId);
        Category result = new Category(catRecord.CategoryId, catRecord.Name);
        db.Close();
        return result;
    }

    public static Category Insert(string name)
    {
        Database db = Database.Open("ProductDb");
        int numRows = db.Execute("INSERT INTO Category (Name) VALUES (@0)", name);
        if (numRows <= 0)
            return null;

        Category result = new Category(db.GetLastInsertId(), name);
        db.Close();
        return result;
    }

    public static bool Update(Category category)
    {
        Database db = Database.Open("ProductDb");
        int numRows = db.Execute("UPDATE Category SET Name=@0 WHERE CategoryId", category.CategoryId);
        db.Close();
        return numRows == 1;
    }

    public static bool Delete(string categoryId)
    {
        Database db = Database.Open("ProductDb");
        int numRows = db.Execute("DELETE FROM Category (Name) WHERE CategoryId = @0", categoryId);
        return numRows == 1;
    }
}