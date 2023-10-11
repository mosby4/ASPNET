using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Testing.Models;

namespace Testing
{
	public class ProductRepository : IProductRepository
	{
		private readonly IDbConnection _conn;
		public ProductRepository(IDbConnection conn)
		{
			_conn = conn;
		}

        public IEnumerable<product> GetAllProducts()
        {
			return _conn.Query<product>("Select * From Products;");
        }
    }
}