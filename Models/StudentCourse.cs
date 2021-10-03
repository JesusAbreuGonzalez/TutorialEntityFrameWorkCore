﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TutorialEntityFrameWorkCore.Models
{
    public partial class StudentCourse
    {
        public int StudentCourseId { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
