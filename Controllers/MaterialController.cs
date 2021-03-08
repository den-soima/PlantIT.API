using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlantIT.API.Models;
using PlantIT.API.Services;

namespace PlantIT.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class MaterialController : ControllerBase
    {
        private readonly IMaterialRepository _materialRepository;

        public MaterialController(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }
        
        [HttpGet]
        public async Task<ActionResult<Material>> GetAll()
        {
            var materials = await _materialRepository.GetAllMaterial();
            return Ok(materials);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Material>> GetById(int id)
        {
            var material = await _materialRepository.GetById(id);
            return Ok(material);
        }
    }
}