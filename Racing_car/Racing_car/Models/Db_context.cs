﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Racing_car.Models
{
    //db connection
    public class Db_context : DbContext
    {
        public Db_context(DbContextOptions<Db_context> options)
            : base(options) { }

        public DbSet<Users> Users { get; set; }
    }
}
