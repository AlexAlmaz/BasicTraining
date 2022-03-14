using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApplication.Models.Tasks
{
    public class WorkItemModel
    {
        [Required]
        [Display(Name = "Task Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Owner")]
        public string Owner { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public bool Done { get; set; }
    }
}
