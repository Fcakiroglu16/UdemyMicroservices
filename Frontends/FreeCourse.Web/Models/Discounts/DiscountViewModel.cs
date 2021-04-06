using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Models.Discounts
{
    public class DiscountViewModel
    {
        public string UserId { get; set; }
        public int Rate { get; set; }
        public string Code { get; set; }
    }
}