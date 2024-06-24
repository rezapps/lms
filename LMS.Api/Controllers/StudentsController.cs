using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LMS.Data.Data;
using LMS.Core.Entities;
using LMS.Core.Dtos;
using AutoMapper;


namespace LMS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly LmsContext _context;
        private readonly IMapper _mapper;

        public StudentsController(LmsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            var students = await _context.Student.ToListAsync();
            var studentDtos = _mapper.Map<IEnumerable<StudentDto>>(students);

            return Ok(studentDtos);
        }


        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _context.Student
                .Include(s => s.Enrollment)
                .FirstOrDefaultAsync(s => s.Id == id);
            
            if (student == null)
            {
                return NotFound();
            }

            var studentDto = _mapper.Map<StudentDto>(student);

            return Ok(studentDto);
        }


    }
}
