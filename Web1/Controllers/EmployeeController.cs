using Microsoft.AspNetCore.Mvc;
using Web1.Data;

namespace Web1.Controllers
{

	public class EmployeeController : Controller
	{
		DbContextApplication context = new DbContextApplication();
		public IActionResult Index()
		{
			var employee = context.employees.ToList();

			string name = "lana";
			return View("ViewEmployee",employee);
		}
	}
}
