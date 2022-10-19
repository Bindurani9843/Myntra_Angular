using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Myntra_Angular.Models
{
    public partial class Registration
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Useremail { get; set; }
        public string? Password { get; set; }
        public string? Mobile { get; set; }
    }
}
