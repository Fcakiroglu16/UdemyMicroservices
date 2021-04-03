using FreeCourse.Web.Models.PhotoStocks;
using FreeCourse.Web.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services
{
    public class PhotoStockService : IPhotoStockService
    {
        public Task<bool> DeletePhoto(string photoUrl)
        {
            throw new NotImplementedException();
        }

        public Task<PhotoViewModel> UploadPhoto(IFormFile photo)
        {
            throw new NotImplementedException();
        }
    }
}