using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Dtos
{
    public class CourseUpdateDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string UserId { get; set; }

        public string Picture { get; set; }
        public FeatureDto Feature { get; set; }

        public string CategoryId { get; set; }
    }
}