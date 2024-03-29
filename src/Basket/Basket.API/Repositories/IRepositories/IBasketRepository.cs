﻿using Basket.API.Entities;
using System.Threading.Tasks;

namespace Basket.API.Repositories.IRepositories
{
    public interface IBasketRepository
    {
        Task<BasketCart> GetBasket(string userName);
        Task<BasketCart> UpdateBasket(BasketCart basket);
        Task<bool> DeleteBasket(string userName);
    }
}
