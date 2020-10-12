using System.Collections.Generic;
public class Person
{
    public string FirstName {get; set; }
    public string SurName {get; set; }
    public string Address {get; set; }
    public char Gender {get; set; } = 'M';
    public double Salary {get; set; }

    public static List<Person> GetEmployee()
    {
        Person empl1 = new Person(){ FirstName = "Uzwal", SurName = "Dhital", Address = "Kathmandu", Salary = 200.0 };
        Person empl2 = new Person(){ FirstName = "Ram", SurName = "Dhital", Address = "Kathmandu", Salary = 200.0 };
        Person empl3 = new Person(){ FirstName = "Razyesh", SurName = "Dhital", Address = "Kathmandu", Salary = 200.0 };
        Person empl4 = new Person(){ FirstName = "Sandesh", SurName = "Dhital", Address = "Kathmandu", Salary = 200.0 };
        Person empl5 = new Person(){ FirstName = "Cosmik", SurName = "Dhital", Address = "Kathmandu", Salary = 200.0 };
        Person empl6 = new Person(){ FirstName = "Junge", SurName = "Dhital", Address = "Kathmandu", Salary = 200.0 };

        List<Person> employees = new List<Person>() {empl1, empl2, empl3, empl4, empl5, empl6};
        return employees;
    }

}