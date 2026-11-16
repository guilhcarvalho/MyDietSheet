public class Week
{
    public int Id { get; set; }
    public required string DayOfWeek { get; set; }
    public int Position { get; set; }

    public ICollection<Planning> Plannings { get; set; } = [];
}
