using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgentPropertySystem.Models
{
    public class AgentDetail
    {
            [Key]
            public Guid AgentID { get; set; }
            public string AgentName { get; set; }
            public int AgentAge { get; set; }
            public string DateOfBirth { get; set; }

            [ForeignKey("PropertyDetails")]
            public string PropertyName { get; set; }
            public PropertyDetail PropertyDetail { get; set; }

        }
    }

