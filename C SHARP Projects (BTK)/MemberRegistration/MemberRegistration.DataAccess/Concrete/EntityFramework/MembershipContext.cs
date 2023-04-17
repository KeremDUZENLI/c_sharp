﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.DataAccess.Concrete.EntityFramework
{
    public class MembershipContext : DbContext
    {
        public MembershipContext()
        {
            Database.SetInitializer<MembershipContext>(null);
        }

        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
        }
    }
}
