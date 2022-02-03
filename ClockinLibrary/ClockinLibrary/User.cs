using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClockLibrary
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        public string FirstName { get; set; }      
        public string LastName { get; set; }
        [Required]
        public int Passcode { get; set; }
        [Required]
        public int BranchID { get; set; }
    }
}