//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using project__1_BookStore_.Models;
//using project__1_BookStore_.Repositry;
//using System.Threading.Tasks;

//namespace project__1_BookStore_.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CatalogController : ControllerBase
//    {
//        private readonly IUnitOfWork _unitOfWork;

//        public CatalogController(IUnitOfWork unitOfWork)
//        {
//            _unitOfWork = unitOfWork;
//        }

//        // POST: api/Catalog
//        [HttpPost]
//        public async Task<IActionResult> AddCatalog([FromBody] Catalog catalog)
//        {
//            if (catalog == null)
//            {
//                return BadRequest("Catalog cannot be null");
//            }

//            try
//            {
//                await _unitOfWork.Catalogs.AddAsync(catalog);  // Add the catalog
//                await _unitOfWork.SaveAsync();  // Commit changes
//                return CreatedAtAction(nameof(GetCatalog), new { id = catalog.Id }, catalog);
//            }
//            catch
//            {
//                return StatusCode(500, "Internal server error");
//            }
//        }

//        // DELETE: api/Catalog/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> RemoveCatalog(int id)
//        {
//            var catalog = await _unitOfWork.Catalogs.GetByIdAsync(id);  // Fetch catalog by id
//            if (catalog == null)
//            {
//                return NotFound("Catalog not found");
//            }

//            try
//            {
//                _unitOfWork.Catalogs.Delete(catalog);  // Remove the catalog
//                await _unitOfWork.SaveAsync();  // Commit changes
//                return NoContent();  // Successfully deleted
//            }
//            catch
//            {
//                return StatusCode(500, "Internal server error");
//            }
//        }

//        // GET: api/Catalog/5 (Get a single catalog by ID)
//        [HttpGet("{id}")]
//        public async Task<IActionResult> GetCatalog(int id)
//        {
//            var catalog = await _unitOfWork.Catalogs.GetByIdAsync(id);
//            if (catalog == null)
//            {
//                return NotFound();
//            }
//            return Ok(catalog);
//        }
//    }
//}
