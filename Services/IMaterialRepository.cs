using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlantIT.API.Models;

namespace PlantIT.API.Services
{
    public interface IMaterialRepository
    {
        ValueTask<Material> GetById(int id);
        Task AddMaterial(Material entity);
        Task UpdateMaterial(Material entity, int id);
        Task RemoveMaterial(int id);
        Task<IEnumerable<Material>> GetAllMaterial();
    }
}