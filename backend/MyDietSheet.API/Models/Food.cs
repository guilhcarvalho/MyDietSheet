public class Food
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string MeansureUnit { get; set; } = string.Empty;
    public double ReferenceQuantity { get; set; }

	public List<FoodNutrient> FoodNutrients {  get; set; }

}
