using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClockLibrary
{
    public class Record
    {
        public int RecordID { get; set; }
        [Required]  
        public int UserID { get; set; }
        public  DateTime Clockin { get; set; }
        public DateTime Clockout { get; set; }
    }
}
