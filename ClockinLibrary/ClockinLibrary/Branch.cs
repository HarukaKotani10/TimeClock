using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClockLibrary
{
    public class Branch
    {
        public int BranchID { get; set; }
        [Required]
        public int BranchName { get; set; }
    }
}
