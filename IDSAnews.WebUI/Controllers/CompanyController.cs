using IDSAnews.Domain.Abstract;
using IDSAnews.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDSAnews.Domain.Interfaces;

namespace IDSAnews.WebUI.Controllers
{
    public class CompanyController : Controller
    {
        private ICompanyRepository repository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            repository = companyRepository;
        }

        //
        // GET: /Company/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Get()
        {
            return Json(repository.Companies.First(), JsonRequestBehavior.AllowGet);
        }

    }
}
