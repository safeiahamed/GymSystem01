using GymSystem.Entities.Enums;

namespace GymSystem.Entities
{
    public class Trainer : GymUser
    {
        public Specialities Speciality { get; set; } = default!;
        public ICollection<Session> Sessions { get; set; } = default!;

    }
}
