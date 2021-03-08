using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using PlantIT.API.Models;
using PlantIT.API.Services.Queries;

namespace PlantIT.API.Services
{
    public class MaterialRepository: BaseRepository, IMaterialRepository
    {
        private readonly ICommandText _commandText;
        public MaterialRepository(IConfiguration configuration, ICommandText commandText) : base(configuration)
        {
            _commandText = commandText;
        }

        public async Task<IEnumerable<Material>> GetAllMaterial()
        {
            return await WithConnection(async conn =>
            {
                var query = await conn.QueryAsync<Material>(_commandText.Get);
                return query;
            });
        }
        
        public async ValueTask<Material> GetById(int id)
        {
            return await WithConnection(async conn =>
            {
                var query = await conn.QueryFirstOrDefaultAsync<Material>(_commandText.GetById, new {nKey = id});
                return query;
            });
        }

        public Task AddMaterial(Material entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateMaterial(Material entity, int id)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveMaterial(int id)
        {
            throw new System.NotImplementedException();
        }


    }
}