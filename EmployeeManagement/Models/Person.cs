using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public Guid Id {get; set; }

    [Required]
    [Display(Name = "First Name")]
    public string FirstName {get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string SurName {get; set; }


    public string Address {get; set; }
    public char? Gender {get; set; } = 'M';
    public double? Salary {get; set; } = null;

    public static List<Person> GetEmployees()
    {
        // Object initializer syntax
        Person empl1 = new Person(){Id= Guid.NewGuid(), FirstName = "Uzwal", SurName = "Dhital", Address = "Jhapa", Salary = 200.0 };
        Person empl2 = new Person(){Id= Guid.NewGuid(), FirstName = "Prabesh", SurName = "Oli", Address = "Nepalgunj", Salary = 300.0 };
        Person empl3 = new Person(){Id= Guid.NewGuid(), FirstName = "Razyesh", SurName = "Pudasaini", Address = "Kathmandu", Salary = 400.0 };
        Person empl4 = new Person(){Id= Guid.NewGuid(), FirstName = "Sandesh", SurName = "Belbase", Address = "Gulmi", Salary = 500.0 };
        Person empl5 = new Person(){Id= Guid.NewGuid(), FirstName = "Cosmik", SurName = "Koirala", Address = "Kapan", Salary = 600.0 };
        Person empl6 = new Person(){Id= Guid.NewGuid(), FirstName = "Junge", SurName = "Karki", Address = "Nagarkot", Salary = 700.0 };

        List<Person> employees = new List<Person>() {empl1, empl2, empl3, empl4, empl5, empl6};
        return employees;
    }

}