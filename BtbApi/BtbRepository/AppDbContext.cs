using BtbDomain.Models;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbRepository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Drink> Drinks => Set<Drink>();
        public DbSet<Measure> Measures => Set<Measure>();
        public DbSet<Ingredient> Ingredients => Set<Ingredient>();
        public DbSet<IngredientMeasure> IngredientsMeasures => Set<IngredientMeasure>();
        public DbSet<RecipeStep> RecipeSteps => Set<RecipeStep>();
        public DbSet<User> Users => Set<User>();
    }
}
