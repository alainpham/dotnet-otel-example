using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using MyBookstoreApi.Models;

[ApiController]
[Route("api/books")]
public class BooksController : ControllerBase
{
    private static List<Book> _books = new List<Book>
    {
        new Book { Id = 1, Title = "Book 1", Author = "Author 1", Price = 19.99 },
        new Book { Id = 2, Title = "Book 2", Author = "Author 2", Price = 24.99 },
        new Book { Id = 3, Title = "Book 3", Author = "Author 3", Price = 14.99 }
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_books);
    }
}
