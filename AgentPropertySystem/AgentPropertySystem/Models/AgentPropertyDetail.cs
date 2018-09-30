using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgentPropertySystem.Models
{
    public class AgentPropertyDetail
    {
        [Key]
        public Guid AgentPropertyID { get; set; }
        public string AgentName { get; set; }
        public int AgentAge { get; set; }
        public string DateOfBirth { get; set; }
        public string PropertyName { get; set; }
        public string PropertyType { get; set; }
    }
}
