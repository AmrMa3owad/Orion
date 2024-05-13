using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Freelancer : BaseEntity<int>
    {
        public Freelancer()
        {
            FreelancerAbove12s = new HashSet<FreelancerAbove12>();
            FreelancerUnder12s = new HashSet<FreelancerUnder12>();
            UserFreelancers = new HashSet<UserFreelancer>();
            UserMentors = new HashSet<UserMentor>();
        }
        public int OrphanageId { get; set; }
        public int Earnings { get; set; }
        public int OrphansNumber { get; set; }
        public string ProductType { get; set; }

        public virtual Orphanage Orphanage { get; set; }
        public virtual ICollection<FreelancerAbove12> FreelancerAbove12s { get; set; }
        public virtual ICollection<FreelancerUnder12> FreelancerUnder12s { get; set; }
        public virtual ICollection<UserFreelancer> UserFreelancers { get; set; }
        public virtual ICollection<UserMentor> UserMentors { get; set; }

    }
}
