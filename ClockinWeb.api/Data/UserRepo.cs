using TimeClockLibrary;

namespace TimeClock.api.Data
{
    public class UserRepo : IUserRepo
    {
        private readonly TimeClockContext _context;

        public UserRepo(TimeClockContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            if(user == null)
                throw new ArgumentNullException(nameof(user));
            
            _context.User.Add(user);
        }

        public IEnumerable<User> GetAppUsers()
        {
            return _context.User.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.User.FirstOrDefault(p => p.UserID == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
