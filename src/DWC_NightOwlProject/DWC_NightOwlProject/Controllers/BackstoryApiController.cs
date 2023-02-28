using DWC_NightOwlProject.DAL.Abstract;
using DWC_NightOwlProject.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DWC_NightOwlProject.Controllers
{
    [Route("api/Backstory")]
    [ApiController]
    public class BackstoryApiController : ControllerBase
    {
        private readonly IRepository<Material> _materialRepo;

        public BackstoryApiController(IRepository<Material> materialRepo)
        {
            _materialRepo = materialRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Material>> GetMaterials()
        {
            var materials = _materialRepo.GetAll();

            if (materials == null)
            {
                return NotFound();
            }
            return Ok(materials);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Material>> GetMaterial(int id)
        {
            Material material = _materialRepo.FindById(id);

            if (material == null) 
            {
                return NotFound();
            }

            return Ok(material);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Material> PostMaterials([Bind("Id, UserId, WorldId, Type, Prompt, Completion")] Material material)
        {
            material.Id = 0;

            Material m = _materialRepo.AddOrUpdate(material);
            return CreatedAtAction("GetMaterials", "Material", m);
        }
    }
}
