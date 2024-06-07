using model.Interfaces;

namespace model.Entities
{
    public class Role : IRole
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}

