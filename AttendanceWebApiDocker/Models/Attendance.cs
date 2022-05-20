using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AttendanceWebApiDocker.Models
{
    public class Attendance
    {
        [Key]
        public string AttendanceId { get; set; }

        public string AttendanceStatus { get; set; }

        public string AttendanceDate { get; set; }
    }
}
