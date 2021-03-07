using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlantIT.API.Entities;

namespace PlantIT.API.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
        Task<IEnumerable<User>> GetAll();
    }
}