using BikeZone.Models;
namespace BikeZone
{
    public interface IUser
    {
        Task Signup(Customer user);
        Task Login(Customer user);
    }
}