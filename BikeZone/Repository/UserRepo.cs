using BikeZone;
using BikeZone.Data;
namespace BikeZone
{
    public class UserRepo : IUser
    {
        private readonly CustomerOrderContext _context;
        public UserRepo(CustomerOrderContext context)
        {
            _context = context;
        }
        public async Task Signup(Customer user)
        {
            _context.Customers.Add(user);
            await _context.SaveChangesAsync();
        }
        public Task Login(Customer user)
        {
            throw new NotImplementedException();
        }

    }
}