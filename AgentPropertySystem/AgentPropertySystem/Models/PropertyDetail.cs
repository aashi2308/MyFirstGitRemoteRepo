using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgentPropertySystem.Models
{
    public class PropertyDetail
    {
        [Key]
        public Guid PropertyID { get; set; }
        public string PropertyName { get; set; }
        public string PropertyType { get; set; }
    }
}
