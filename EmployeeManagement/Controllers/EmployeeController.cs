using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        var employees = Person.GetEmployees();
        return View(employees);

    }

    public ActionResult Detail([FromQuery] Guid id)
    {
       var employees = Person.GetEmployees();
       Person employee = employees.FirstOrDefault(x => x.Id.ToString() == id.ToString());

       return View(employee);
    }
    [HttpGet]

    public ActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public ActionResult<String> Add(Person person)
    {
       return "Record Saved";
    }
}

