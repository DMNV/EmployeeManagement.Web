using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using EmployeeManagement.Web.UI.DataAccess;
using EmployeeManagement.Web.UI.Models;
using EmployeeManagement.Web.UI.ViewModels;

namespace EmployeeManagement.Web.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeManagementContext db = new EmployeeManagementContext();

        // GET: Employee
        public ActionResult Index()
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.EmployeeList = db.EmployeeDbSet.ToList();
            employeeViewModel.CountyList = db.CountyDbSet.ToList();
            employeeViewModel.CityList = db.CityDbSet.ToList();
            employeeViewModel.SalaryList = db.SalaryDbSet.ToList();

            return View(employeeViewModel);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Employee employee = db.EmployeeDbSet.Find(id);

            if(employee == null)
            {
                return HttpNotFound();
            }

            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
             
            employeeViewModel.CountySelectList = new SelectList(db.CountyDbSet.ToList(), "ID", "Name", "--Select County--");
            employeeViewModel.CitySelectList = new SelectList(db.CityDbSet.ToList(), "ID", "Name", "--Select City--");
            employeeViewModel.SalarySelectList = new SelectList(db.SalaryDbSet.ToList(), "ID", "Amount", "--Select Salary--");

            employeeViewModel.Employee = new Models.Employee()
            {

            };

            return View(employeeViewModel);
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                // TODO: Add insert logic here
                if(ModelState.IsValid)
                {
                    db.EmployeeDbSet.Add(employee);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        /// <summary>
        /// Edits the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            EmployeeViewModel employeeViewModel = new EmployeeViewModel();

            employeeViewModel.CountySelectList = new SelectList(db.CountyDbSet.ToList(), "ID", "Name", "--Select County--");
            employeeViewModel.CitySelectList = new SelectList(db.CityDbSet.ToList(), "ID", "Name", "--Select City--");
            employeeViewModel.SalarySelectList = new SelectList(db.SalaryDbSet.ToList(), "ID", "Amount", "--Select Salary--");


            employeeViewModel.Employee = db.EmployeeDbSet.Find(id);

            if (employeeViewModel == null)
            {
                return HttpNotFound();
            }

            return View(employeeViewModel);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
