using EmployeePayroll_v2.Models;
using EmployeePayroll_v2.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace EmployeePayroll_v2.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDAO EmployeeDAO;

        // CONSTRUCTOR
        public EmployeeController()
        {
            EmployeeDAO = new EmployeeDAO();
        }

        // GET : Employee
        public async Task<IActionResult> Index()
        {
            List<Employee> employees = EmployeeDAO.GetAllEmployees();
            return View(employees);
        }

        // GET: Employee/Details/?
        public async Task<IActionResult> Details(int id)
        {
            Employee employee = EmployeeDAO.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET : Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST : Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LastName,FirstName,BirthDate,TIN,EmployeeType,MonthlyRate,DailyRate")] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }

            string errorDescription = ValidateEmployee(employee);
            if (errorDescription != "")
            {
                ModelState.AddModelError("ErrorDescription", errorDescription);
                return View(employee);
            }

            EmployeeDAO.Insert(employee);
            employee = EmployeeDAO.GetEmployeeByName(employee.LastName, employee.FirstName);
            List<Employee> employees =  new List<Employee> { employee };
            return View("Index", employees);
        }

        private string ValidateEmployee(Employee employee)
        {
            string errorDescription = "";

            if (employee.EmployeeType == EnumEmployeeTypes.Regular && employee.MonthlyRate == 0)
            {
                errorDescription = employee.GetDisplayName("MonthlyRate") + " cannot be zero for regular employees.";
                return errorDescription;
            }
            if (employee.EmployeeType == EnumEmployeeTypes.Contractual && employee.DailyRate == 0)
            {
                errorDescription = employee.GetDisplayName("DailyRate") + " cannot be zero for contractual employees.";
                return errorDescription;
            }
            errorDescription = EmployeeDAO.ValidateEmployee(employee);
            if (errorDescription != "")
            {
                return errorDescription;
            }
            return "";
        }

        // GET: Employee/Edit/?
        public async Task<IActionResult> Edit(int id)
        {
            Employee employee = EmployeeDAO.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/Edit/?
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LastName,FirstName,BirthDate,TIN,EmployeeType,MonthlyRate,DailyRate")] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }

            string errorDescription = ValidateEmployee(employee);
            if (errorDescription != "")
            {
                ModelState.AddModelError("ErrorDescription", errorDescription);
                return View(employee);
            }

            EmployeeDAO.Update(employee);
            employee = EmployeeDAO.GetEmployeeById(employee.Id);
            List<Employee> employees = new List<Employee> { employee };
            return View("Index", employees);
        }

        // GET: Employee/Delete/?
        public async Task<IActionResult> Delete(int id)
        {
            Employee employee = EmployeeDAO.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
           return View(employee);
        }

        // POST: Employee/Delete/?
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            EmployeeDAO.Delete(id);
            List<Employee> employees = EmployeeDAO.GetAllEmployees();
            return View("Index", employees);
        }

        public async Task<IActionResult> SearchForm()
        {
            return View();
        }

        public async Task<IActionResult> SearchEmployees(string searchKey)
        {
            List<Employee> employees = EmployeeDAO.GetEmployeesByKey(searchKey);
            return View("Index", employees);
        }

        public async Task<IActionResult> ShowCalculate(int id)
        {
            Employee employee = EmployeeDAO.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }

            PaySlip paySlip = new PaySlip();
            paySlip.Id = employee.Id;
            paySlip.LastName = employee.LastName;
            paySlip.FirstName = employee.FirstName;
            paySlip.BirthDate = employee.BirthDate;
            paySlip.TIN = employee.TIN;
            paySlip.EmployeeType = employee.EmployeeType;
            paySlip.MonthlyRate = employee.MonthlyRate;
            paySlip.DailyRate = employee.DailyRate;
            paySlip.PresentDays = 0;
            paySlip.AbsentDays = 0;
            paySlip.Deductions = 0;
            paySlip.TaxableAmount = 0;
            paySlip.Tax = 0;
            paySlip.Salary = 0;
            return View(paySlip);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ShowPayslip(PaySlip paySlip)
        {
            if (paySlip.EmployeeType == EnumEmployeeTypes.Regular)
            {
                paySlip.Deductions = paySlip.AbsentDays * (paySlip.MonthlyRate / 22);
                paySlip.TaxableAmount = paySlip.MonthlyRate - paySlip.Deductions;
            }
            else
            {
                paySlip.Deductions = 0;
                paySlip.TaxableAmount = paySlip.PresentDays * paySlip.DailyRate;
            }
            paySlip.Tax = paySlip.TaxableAmount * (decimal)0.12;
            paySlip.Salary = paySlip.TaxableAmount - paySlip.Tax;
            return View(paySlip);
        }
    }
}
