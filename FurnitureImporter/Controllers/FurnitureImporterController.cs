using FurnitureImporter.Ports.Web.Interfaces;
using FurnitureImporter.Ports.Web.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureImporter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FurnitureImporterController : Controller
    {
        private readonly IFurnitureImporterManager _manager;
        
        public FurnitureImporterController(IFurnitureImporterManager manager) { 
            _manager = manager;
        }

        [HttpGet("Test")]
        public int Get()
        {
            return _manager.GetNumber();
        }

        [HttpGet("GetAllCustumers")]
        public IEnumerable<Customer> GetAllCustumers()
        {
            return _manager.GetAllCustumers();
        }

        [HttpGet("GetAllFurnitures")]
        public IEnumerable<Furniture> GetAllFurnitures()
        {
            return _manager.GetAllFurnitures();
        }

        [HttpGet("{custumerId}/GetDiscountedPriece/{furnitureId}")]
        public double GetDiscountePrice([FromRoute] Guid custumerId, [FromRoute] Guid furnitureId)
        {
            return _manager.GetDiscountePrice(custumerId, furnitureId);
        }
    }
}
