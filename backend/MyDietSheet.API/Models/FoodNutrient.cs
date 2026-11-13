public class FoodNutrient
{
    public int FoodId { get; set; }
    public Food Food { get; set; } = null!;


    public int NutrientId { get; set; }
    public Nutrient Nutrient { get; set; } = null!;


    public required double Value { get; set; }
}
