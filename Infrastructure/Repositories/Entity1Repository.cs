using Domain.Entities;
using Domain.Repositories;


namespace Infrastructure.Repositories
{
    public class Entity1Repository : IEntity1Repository
    {
        public Task<bool> CreateAsync(Entity1 entity1, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entity1>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Entity1> GetByIdAsync(string id)
        {
            var entity1 = new Entity1 { Id = id, Prop2 = "bla" };
            return Task.FromResult(entity1);
        }

        public Task<bool> UpdateAsync(Entity1 entity1, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
