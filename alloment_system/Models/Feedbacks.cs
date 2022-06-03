using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace alloment_system.Models
{
    public class Feedbacks
    {
    
            [Required]
            public int NameID { get; set; }
            [Required]
            public string Email { get; set; }
            [Required]
            public string Message { get; set; }
         
 
    }
}