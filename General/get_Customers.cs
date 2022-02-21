using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PointofSaleSoftware.General
{
    public class get_Customers
    {
        [Display(Name = "ID")]
        public int custID { get; set; }
        [Display(Name = "Name")]
        public string custName { get; set; }
        [Display(Name = "Address")]
        public string custAdd { get; set; }
        [Display(Name = "Cell #")]
        public string custCell { get; set; }
    }
}
