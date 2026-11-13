public class Meal
{
    public int Id { get; set; }
    public required string Name { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }


    public List<MealItem> Items { get; set; } = [];
    public List<Planning> Plannings { get; set; } = [];

}
