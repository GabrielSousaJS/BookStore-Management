using BookStoreManagement.Communication.Requests;
using BookStoreManagement.Communication.Responses;
using BookStoreManagement.Database;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreManagement.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BooksController : BookStoreManagementBaseController
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBook), StatusCodes.Status201Created)]
    public IActionResult Create(RequestRegisterBook request)
    {
        ResponseRegisterBook response = new()
        {
            Title = request.Title,
            Author = request.Author,
            Genre = request.Genre,
            Price = request.Price
        };

        BookCatalog.AddBook(Guid.NewGuid().ToString(), request);

        return Created(string.Empty, response);
    }

    [HttpGet("all-books")]
    [ProducesResponseType(typeof(ResponseAllBooks), StatusCodes.Status200OK)]
    public IActionResult Get() 
    {
        var response = new ResponseAllBooks();

        return Ok(response.Books);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Update(string id, RequestUpdateBook request)
    {
        var response = new ResponseUpdateBook();

        response.Book = BookCatalog.Update(id, request);

        return Ok(response.Book);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete(string id)
    {
        BookCatalog.Delete(id);

        return NoContent();
    }
}
