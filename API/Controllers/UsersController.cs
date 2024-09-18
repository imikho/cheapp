using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class UsersController(DataContext context): ControllerBase
{
    private readonly DataContext _context = context;

    [HttpGet]
    public ActionResult<IEnumerable<AppUser>> GetUsers()
    {
        var users = _context.Users.ToList();

        return users;
    }

    [HttpGet("{id:int}")]
    public ActionResult<AppUser> GetUser(int id)
    {
        var user = _context.Users.Find(id);

        if (user == null) return NotFound();

        return user;
    }
}
