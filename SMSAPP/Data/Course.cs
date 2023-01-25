using System;
using System.Collections.Generic;

namespace SMSAPP.Data;

public partial class Course
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public string? CourseCode { get; set; }

    public int? CourseCredits { get; set; }
}
