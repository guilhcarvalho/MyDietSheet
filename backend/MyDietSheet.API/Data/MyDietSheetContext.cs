using Microsoft.EntityFrameworkCore;

namespace MyDietSheet.API.Data

public class MyDietSheetContext: DbContext
{
    public MyDietSheetContext(DbContextOptions<MyDietSheetContext> options): base(options)
    {
    }

    public DbSet<Food> Foods { get; set }
    public DbSet<FoodNutrient> FoodNutrients { get; set }
    public DbSet<Meal> Meals { get; set }
    public DbSet<MealItem> Items { get; set }
    public DbSet<Nutrient> Nutrients { get; set }
    public DbSet<Planning> Plannings { get; set }
    public DbSet<Week> Weeks { get; set }
    public DbSet<User> Users { get; set }

}
