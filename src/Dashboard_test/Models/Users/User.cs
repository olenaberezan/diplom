﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard_test.Models
{
    public class User : IdentityUser
    {
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public DateTime Birth { get; set; }

        public string Avatar { get; set; }
        public int? StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
        public int? TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }
        public User()
        {
            //Dashboards = new HashSet<Dashboard>();
        }
        //public virtual ICollection<Dashboard> Dashboards { get; set; }
    }
}
