using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2WebApi.Models;

namespace Task2WebApi.Services
{
	public class ProductService
	{
		private static List<Product> products;

		public ProductService()
		{
			if(products == null)
			products = new List<Product>
			{
				new Product{Id=1, Name= "Product 1", Price= 12, Vendor = "USA"},
				new Product{Id=2, Name= "Product 2", Price= 12, Vendor = "China"},
				new Product{Id=3, Name= "Product 3", Price= 12, Vendor = "Poland"},
				new Product{Id=4, Name= "Product 4", Price= 12, Vendor = "Canada"},
				new Product{Id=5, Name= "Product 5", Price= 12, Vendor = "SAR"}
			};
		}

		public List<Product> GetAll() => products;

		public void AddProduct(Product product)
		{
			product.Id = products.Count() + 1;
			products.Add(product);
		}

		public bool RemoveProduct(int id)
		{
			return products.Remove(products.FirstOrDefault(p => p.Id.Equals(id)));
		}

		public Product GetById(int id) => products.FirstOrDefault(p => p.Id.Equals(id));
    }
}
