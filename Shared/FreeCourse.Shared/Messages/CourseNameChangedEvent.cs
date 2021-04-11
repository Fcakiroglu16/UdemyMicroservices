using System;
using System.Collections.Generic;
using System.Text;

namespace FreeCourse.Shared.Messages
{
    public class CourseNameChangedEvent
    {
        public string CourseId { get; set; }
        public string UpdatedName { get; set; }
    }
}