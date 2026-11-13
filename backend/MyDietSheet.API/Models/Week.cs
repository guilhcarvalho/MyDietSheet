public class Week
{
    public int Id { get; set; }
    public string DayOfWeek { get; set; }
    public int Position { get; set; }

    public List<Planning> Plannings { get; set; } = [];
}
