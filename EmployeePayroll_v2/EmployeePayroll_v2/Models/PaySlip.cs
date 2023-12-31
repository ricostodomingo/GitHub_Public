using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EmployeePayroll_v2.Models
{
    public class PaySlip : Employee
    {
        [Range(0, 31, ErrorMessage = "Days present must be a number from 0 to 31.")]
        [DisplayName("Days Present")]
        public decimal PresentDays { get; set; }

        [Range(0, 31, ErrorMessage = "Days absent must be a number from 0 to 31.")]
        [DisplayName("Days Absent")]
        public decimal AbsentDays { get; set; }

        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Deductions must be a positive number.")]
        [DataType(DataType.Currency)]
        [DisplayName("Deductions")]
        public decimal Deductions { get; set; }

        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Taxable amount must be a positive number.")]
        [DataType(DataType.Currency)]
        [DisplayName("Taxable Amount")]
        public decimal TaxableAmount { get; set; }

        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Tax must be a positive number.")]
        [DataType(DataType.Currency)]
        [DisplayName("Tax")]
        public decimal Tax { get; set; }

        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Salary must be a positive number.")]
        [DataType(DataType.Currency)]
        [DisplayName("Salary")]
        public decimal Salary { get; set; }
    }
}
