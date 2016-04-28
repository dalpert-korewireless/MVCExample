using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExample.Models;

namespace MVCExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataProvider _companyDataProvider;

        public HomeController(IDataProvider companyDataProvider)
        {
            _companyDataProvider = companyDataProvider;
        }

        //
        // GET: /Home/
        public ActionResult Index()
        {
            var companies = _companyDataProvider.GetCompanies();
            var employees = _companyDataProvider.GetEmployees();
            var viewModel =
                companies.Select(
                    c => new EmployeesByCompanyPickerViewModel
                    {
                        Id = c.Id,
                        Name = c.Name,
                        Employees = employees.Where(e => e.CompanyId == c.Id)
                                             .ToArray()
                    })
                    .ToArray();

            return View(viewModel);
        }
    }
}
