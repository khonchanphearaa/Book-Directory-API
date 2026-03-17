using BooksDirectoryAPI.Models;
using BooksDirectoryAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AuthorsController : ControllerBase
{
    private readonly IAuthorRepository _repo;

    public AuthorsController(IAuthorRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
        => Ok(await _repo.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> Create(Author author)
        => Ok(await _repo.CreateAsync(author));
}