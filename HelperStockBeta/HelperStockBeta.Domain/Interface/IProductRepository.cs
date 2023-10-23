﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperStockBeta.Domain.Interface
{
    public interface IProductRepository()
	{
		//Assinaturas Customizadas
		Task<IEnumerable<Product>> GetProductsAsync();
		Task<Product> GetByIdAsync(int id);
		Task<Product> GetProductCategoryAsync(int id);

		//Assinaturas do CRUD
		Task<Product> CreateAsync(IProductRepository product);
		Task<Product> UpdateAsync(IProductRepository product);
		Task<Product> RemoveAsync(IProductRepository product);

	}
}
