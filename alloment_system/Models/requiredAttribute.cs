using System;

namespace alloment_system.Models
{
    internal class requiredAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
}