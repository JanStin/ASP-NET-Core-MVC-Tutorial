﻿using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext 
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options) 
            : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
