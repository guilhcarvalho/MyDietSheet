public class Meal
{
    public int Id { get; set; }
    public required string Name { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }


    public ICollection<MealItem> Items { get; set; } = [];
    public ICollection<Planning> Plannings { get; set; } = [];

}
