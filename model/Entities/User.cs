using model.Interfaces;

namespace model.Entities
{
    public class User : IUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
    }
}
