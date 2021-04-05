using FreeCourse.Web.Models.Baskets;
using FreeCourse.Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services
{
    public class BasketService : IBasketService
    {
        private readonly HttpClient _httpClient;

        public BasketService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task AddBasketItem(BasketItemViewModel basketItemViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ApplyDiscount(string discountCode)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CancelApplyDiscount()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete()
        {
            throw new NotImplementedException();
        }

        public Task<BasketViewModel> Get()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveBasketItem(string courseId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveOrUpdate(BasketViewModel basketViewModel)
        {
            throw new NotImplementedException();
        }
    }
}