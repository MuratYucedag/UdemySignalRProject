using SignalR.EntiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
	public interface IProductDal : IGenericDal<Product>
	{
		List<Product> GetProductsWithCategories();
		int ProductCount();
		int ProductCountByCategoryNameHamburger();
		int ProductCountByCategoryNameDrink();
		decimal ProductPriceAvg();
		string ProductNameByMaxPrice();
		string ProductNameByMinPrice();
		decimal ProductAvgPriceByHamburger();
		decimal ProductPriceBySteakBurger();
		decimal TotalPriceByDrinkCategory();
		decimal TotalPriceBySaladCategory();
		List<Product> GetLast9Products();
	}
}
