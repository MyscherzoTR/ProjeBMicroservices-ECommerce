﻿using Course.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Services.Discount.Services
{
    public interface IDiscountService
    {
        Task<Response<List<Models.Discount>>> GettAll();

        Task<Response<Models.Discount>> GettById(int id);
        Task<Response<NoContent>> Save(Models.Discount discount);
        Task<Response<NoContent>> Update(Models.Discount discount);
        Task<Response<NoContent>> Delete(Models.Discount discount);
        Task<Response<Models.Discount>> GetByCodeAndUserId(string code, string userId);
    }
}
