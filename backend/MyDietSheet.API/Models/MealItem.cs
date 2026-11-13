public class MealItem
{
    public int Id { get; set; }
    public double Quantity { get; set; }

    public int MealId { get; set; }
    public Meal Meal { get; set; } = null!;
    
    public int FoodId { get; set; }
    public Food Food { get; set; } = null!;
}
