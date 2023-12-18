using System;
using System.Collections.Generic;

namespace EmployeeApp.Model;

public partial class Employee
{
    public int Id { get; set; }

    public string Department { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string City { get; set; } = null!;

    public string StreetNumber { get; set; } = null!;

    public string UnitNumber { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public DateTime Birthday { get; set; }

    public DateTime HiringDate { get; set; }

    public decimal Salary { get; set; }

    public string AboutCompany { get; set; } = null!;

    public string StreetName { get; set; } = null!;
}
