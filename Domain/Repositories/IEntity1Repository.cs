using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IEntity1Repository
    {
        Task<Entity1> GetByIdAsync(string id);
        Task<IEnumerable<Entity1>> GetAllAsync(CancellationToken cancellationToken);
        Task<bool> CreateAsync(Entity1 entity1, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(Entity1 entity1, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(string id, CancellationToken cancellationToken);


    }
}
