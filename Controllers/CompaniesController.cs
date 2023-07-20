using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApp.Data;
using TestApp.Data.Dto;

namespace TestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly CompanyContext context;
        private readonly IMapper mapper;

        public CompaniesController(CompanyContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyDto>>> Get()
        {
            var companies = await context.Companies.ToListAsync();
            return Ok(mapper.Map<IEnumerable<CompanyDto>>(companies));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> Get(int id)
        {
            var company = await context.Companies
                .Include(x => x.History)
                .Include(x => x.Employees)
                .Include(x => x.Notes)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (company == null)
                return NotFound();

            return Ok(company);
        }

        [HttpPost]
        public async Task<ActionResult<Company>> Post([FromBody] CompanyCreateDto companyCreateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var company = mapper.Map<Company>(companyCreateDto);
            await context.AddAsync(company);
            await context.SaveChangesAsync();

            return Ok(company);
        }

        [HttpGet("{id}/history")]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetHistory(int id)
        {
            var orders = await context.Orders
                .Where(o => o.CompanyId == id)
                .ToListAsync();

            return Ok(mapper.Map<IEnumerable<OrderDto>>(orders));
        }

        [HttpGet("{id}/notes")]
        public async Task<ActionResult<IEnumerable<NoteDto>>> GetNotes(int id)
        {
            var notes = await context.Notes
                .Where(o => o.CompanyId == id)
                .ToListAsync();

            return Ok(mapper.Map<IEnumerable<NoteDto>>(notes));
        }

        [HttpGet("{id}/employees")]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> GetEmployees(int id)
        {
            var employees = await context.Employees
                .Where(o => o.CompanyId == id)
                .ToListAsync();

            return Ok(mapper.Map<IEnumerable<EmployeeDto>>(employees));
        }
    }
}
