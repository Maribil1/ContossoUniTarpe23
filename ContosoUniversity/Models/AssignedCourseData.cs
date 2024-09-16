﻿using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Models
{
    public class AssignedCourseData 
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public bool Assigned { get; set; }

    }
}
