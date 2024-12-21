using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project__1_BookStore_.Models;
using project__1_BookStore_.Repositry;

namespace project__1_BookStore_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BooksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/books
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _unitOfWork.Books.GetAllAsync();
            return Ok(books);
        }

        // POST: api/books
        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }

            await _unitOfWork.Books.AddAsync(book);
            await _unitOfWork.SaveAsync();

            return CreatedAtAction(nameof(GetBooks), new { id = book.Id }, book);
        }

    }

}
