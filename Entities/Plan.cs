namespace GymSystem.Entities
{
    public class Plan : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public int DurationDays { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public ICollection<MemberShip> MemberSubscription { get; set; } = default!;


    }
}
