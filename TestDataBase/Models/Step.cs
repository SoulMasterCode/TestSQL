using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDataBase.Models
{
    public class Step
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Detail { get; set; }

        public Int16 Order { get; set; }

        [ForeignKey("Project")]
        public Guid ProjectId { get; set; }

        [ForeignKey("Project")]
        public virtual Project Project { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }

        [ForeignKey("User")]
        public virtual User User { get; set; }
    }
}