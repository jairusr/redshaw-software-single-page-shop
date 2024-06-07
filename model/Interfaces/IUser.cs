using System.Security.Principal;

namespace model.Interfaces
{
    public interface IUser
    {
        string Id { get; set; }
        string UserName { get; set; }
        string PasswordHash { get; set; }
    }
}
