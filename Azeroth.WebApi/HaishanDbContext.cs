﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Azeroth.WebApi
{
    public class HaishanDbContext : System.Data.Entity.DbContext,IScoped
    {
        public HaishanDbContext():base("name=mastermssqlserver")
        {

        }

        public virtual DbSet<InspectConfigResultStatus> InspectConfigResultStatuses { set; get; }
        
    }
}