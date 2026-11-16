public class User
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public Guid Uuid { get; set; } = Guid.NewGuid();

    public ICollection<Meal> Meals { get; set; } = [];
}
