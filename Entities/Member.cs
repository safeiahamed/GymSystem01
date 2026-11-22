namespace GymSystem.Entities
{
    public class Member :GymUser
    {
        public string? Photo { get; set; }
        public ICollection<MemberShip> MemberSubscription { get; set; } = default!;
    }
}
