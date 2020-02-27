using System.Collections.Generic;
using System.Threading.Tasks;
using DieKombuis.API.Models;

namespace DieKombuis.API.Data
{
    public interface IDieKombuisRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}