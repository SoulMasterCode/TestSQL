using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestDataBase.Models
{
    public class Project
    {
        [Key]
        public Guid id { get; set; }

        public String name { get; set; }
    }
}