using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyWebApp.Models
{
    public class Dept
    {
        public int DeptID { get; set; }
        [Required(ErrorMessage = "Please enter a Dept name.")]
        public String Dname { get; set; }
        public int LocID { get; set; }
        public Loc loc { get; set; }

    }
}
