using datasource.Repositories;

namespace service
{
    public class UserService
    {    
        private UserRepository _userRepository {get; set;}
        public UserService(UserRepository userRepository){
            _userRepository = userRepository;
        }        
    }
}