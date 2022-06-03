using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace alloment_system.Models

{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web;
    public class Product
    {


            public int P_id { get; set; }
            [Display(Name = "Image: ")]
            public string P_image { get; set; }
            [Display(Name = "Product Name: ")] 
            public string P_name { get; set; }
            [Display(Name = "Product Price: ")]
            public string P_price { get; set; }
            
            public HttpPostedFileBase p_path { get; set; }

           

        
    }


}