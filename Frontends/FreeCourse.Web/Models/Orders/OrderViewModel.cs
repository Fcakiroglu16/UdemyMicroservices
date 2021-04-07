using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Models.Orders
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        //Ödeme geçmişimde adress alanına ihtiyaç olmadığından dolayı alınmadı
        // public AddressDto Address { get; set; }

        public string BuyerId { get; set; }

        public List<OrderItemViewModel> OrderItems { get; set; }
    }
}