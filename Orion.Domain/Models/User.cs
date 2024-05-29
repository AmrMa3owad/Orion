using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class User : BaseEntity<int>
    {
        public User()
        {
            UserFreelancers = new HashSet<UserFreelancer>();
            UserMentors = new HashSet<UserMentor>();
            UserPremiumUsers = new HashSet<UserPremiumUser>();
            UserCustomers = new HashSet<UserCustomer>();
            UserEmployees = new HashSet<UserEmployee>();

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }

        public virtual ICollection<UserFreelancer> UserFreelancers { get; set; }
        public virtual ICollection<UserMentor> UserMentors { get; set; }
        public virtual ICollection<UserPremiumUser> UserPremiumUsers { get; set; }
        public virtual ICollection<UserCustomer> UserCustomers { get; set; }
        public virtual ICollection<UserEmployee> UserEmployees { get; set; }

    }
}
