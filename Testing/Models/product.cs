﻿using System;
namespace Testing.Models
{
	public class product
	{
		public product()
		{
		}
		public int ProductID { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public int CategoryId { get; set; }
		public int OnSale { get; set; }
		public int StockLevel { get; set; }

	}
}

