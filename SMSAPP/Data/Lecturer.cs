using System;
using System.Collections.Generic;

namespace SMSAPP.Data;

public partial class Lecturer
{
    public int LecturerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }
}
