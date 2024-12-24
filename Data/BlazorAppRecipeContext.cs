using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorWebAppRecipe.Models;

namespace BlazorAppRecipe.Data
{
    public class BlazorAppRecipeContext : DbContext
    {
        public BlazorAppRecipeContext (DbContextOptions<BlazorAppRecipeContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorWebAppRecipe.Models.Recipe> Recipe { get; set; } = default!;
    }
}
