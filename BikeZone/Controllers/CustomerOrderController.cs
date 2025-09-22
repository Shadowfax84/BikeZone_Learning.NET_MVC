using BikeZone;
using Microsoft.AspNetCore.Mvc;
namespace BikeZone
{
    public class CustomerOrderController : Controller
    {
        private readonly IUser _repo;
        public CustomerOrderController(IUser repo)
        {
            _repo = repo;
        }

        public async Task<async> SignupAsync(Customer user)
        {
            await _repo.Signup(user)
            return View();
        }
    }
}