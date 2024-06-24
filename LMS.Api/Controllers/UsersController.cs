using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LMS.Data.Data;
using LMS.Core.Entities;
using LMS.Core.Dtos;
using AutoMapper;

namespace LMS.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly LmsContext _context;
    private readonly IMapper _mapper;

    public UsersController(LmsContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
    {
        var users = await _context.User.ToListAsync();
        return Ok(_mapper.Map<IEnumerable<UserDto>>(users));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserDto>> GetUser(int id)
    {
        var user = await _context.User.FindAsync(id);

        if (user == null)
        {
            return NotFound();
        }

        return Ok(_mapper.Map<UserDto>(user));
    }
    
}
