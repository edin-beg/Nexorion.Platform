
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Interfaces;
using Nexorion.Core.Models;

[ApiController]
[Route("api/tenants")]
public class TenantController : ControllerBase
{
    private readonly ITenantRepository _repo;

    public TenantController(ITenantRepository repo) => _repo = repo;

    [HttpGet("all")]
    public async Task<IEnumerable<Tenant>> Get() => await _repo.GetAllAsync();

    [HttpGet("{id}")]
    public async Task<Tenant> GetById(Guid id) => await _repo.GetByIdAsync(id);

    [HttpPost("create")]
    public async Task<IActionResult> Post([FromBody] Tenant tenant)
    {
        await _repo.InsertAsync(tenant);
        return Ok();
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] Tenant tenant)
    {
        tenant.Id = id;
        await _repo.UpdateAsync(tenant);
        return Ok();
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var tenant = await _repo.GetByIdAsync(id);
        if (tenant == null)
        {
            return NotFound();
        }
        tenant.IsDeleted = true;
        await _repo.UpdateAsync(tenant);
        return Ok();
    }
}
