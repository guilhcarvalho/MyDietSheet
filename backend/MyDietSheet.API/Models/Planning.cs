public class Planning
{
    public int Id { get; set; }
    public TimeOnly MealTime { get; set; }

    public int MealId { get; set; }
    public Meal Meal { get; set; } = null!;

    public int WeekId { get; set; }
    public Week Week { get; set; } = null!;
}
