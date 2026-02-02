using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace w4d3CheckOutAPI.Models
{
    public class Student
    {
        public int Id { get; set; } 
        public string? FullName { get; set; }    
        public string? Email { get; set; }   
        public int? DeviceCheckedOutId { get; set; }
    }
}