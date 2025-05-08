using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Interfaces;
using Nexorion.Core.Models;
using NPoco;

namespace Infrastructure.Repositories
{
    public class TenantRepository : ITenantRepository
    {
        private readonly IDatabase _db;

        public TenantRepository(IDatabase db)
        {
            _db = db;
        }

        public async Task<Tenant> GetByIdAsync(Guid id) => await _db.SingleOrDefaultAsync<Tenant>("WHERE id = @0", id);

        public async Task<IEnumerable<Tenant>> GetAllAsync() => await _db.FetchAsync<Tenant>();

        public async Task InsertAsync(Tenant entity) => await _db.InsertAsync(entity);

        public async Task UpdateAsync(Tenant entity) => await _db.UpdateAsync(entity);


        public async Task<Tenant> GetByCodeAsync(string code) => await _db.SingleOrDefaultAsync<Tenant>("WHERE code = @0", code);
    }
}
