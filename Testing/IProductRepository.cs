using System;
using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
	public interface IProductRepository
	{
		public IEnumerable<product> GetAllProducts();
		public product GetProduct(int id);

    }
}

