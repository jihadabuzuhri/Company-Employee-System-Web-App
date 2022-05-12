using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyWebApp.Models
{
    public class Emp
    {
        public int EmpID { get; set; }
        
        [Required(ErrorMessage = "Please enter a Emp name.")]
        public String Ename { get; set; }
        public String Job { get; set; }
        public int Sal { get; set; }
        public int DeptID { get; set; }
        public Dept dept { get; set; }
    }
}
