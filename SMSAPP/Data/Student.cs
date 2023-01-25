using System;
using System.Collections.Generic;

namespace SMSAPP.Data;

public partial class Student
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public DateTime? DateOfBirth { get; set; }
}
