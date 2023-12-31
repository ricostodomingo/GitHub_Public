using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using System.Reflection;
using System.Linq;

namespace EmployeePayroll_v2.Models
{
    public enum EnumEmployeeTypes
    {
        Regular = 0,
        Contractual = 1
    }

    public class Employee
    {
        private string _LastName;
        private string _FirstName;

        [DisplayName("System Id")]
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [DisplayName("Last Name")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value.Trim(); }
        }

        [StringLength(100, MinimumLength = 2)]
        [DisplayName("First Name")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value.Trim(); }
        }

        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        public DateTime BirthDate { get; set; }

        [RegularExpression("^[0-9]{9}$", ErrorMessage = "TIN must be 9-characters long and numeric.")]
        [DisplayName("TIN")]
        public string TIN { get; set; }

        [DisplayName("Employee Type")]
        public EnumEmployeeTypes EmployeeType { get; set; }

        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Monthly rate must be a positive number.")]
        [DataType(DataType.Currency)]
        [DisplayName("Monthly Rate")]
        public decimal MonthlyRate { get; set; }

        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Daily rate must be a positive number.")]
        [DataType(DataType.Currency)]
        [DisplayName("Daily Rate")]
        public decimal DailyRate { get; set; }

        public string GetDisplayName(string name)
        {
            MemberInfo property = typeof(Employee).GetProperty(name);
            var attribute = property.GetCustomAttributes(typeof(DisplayNameAttribute), true)
                .Cast<DisplayNameAttribute>().Single();
            string displayName = attribute.DisplayName;
            return (displayName);
        }
    }
}
