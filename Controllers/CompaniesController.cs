using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApp.Data;
using TestApp.Data.Dto;

namespace TestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyContext context;
        private readonly IMapper mapper;

        public CompanyController(CompanyContext context, IMapper mapper)
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
            var company = await context.Companies.FindAsync(id);
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

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
