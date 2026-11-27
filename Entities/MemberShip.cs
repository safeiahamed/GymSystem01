using System.ComponentModel.DataAnnotations.Schema;

namespace GymSystem.Entities
{
    public class MemberShip : BaseEntity
    {
        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;
        public int PlanId { get; set; }
        public Plan Plan { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "UpComming"
                                : EndDate > DateTime.Now ? "Active"
                                : "Expired";

    }
}
