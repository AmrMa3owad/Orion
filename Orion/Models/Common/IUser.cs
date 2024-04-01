namespace Orion.Models.Common
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Gender { get; set; }
        string Address { get; set; }
        DateTime BirthDate { get; set; }
    }
}
