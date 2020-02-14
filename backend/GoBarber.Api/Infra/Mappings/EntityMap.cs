using GoBarber.Api.Domain.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoBarber.Api.Infra.Mappings
{
    public abstract class EntityMap<TEntity>
        where TEntity: class, IEntity<TEntity>
    {
        public EntityMap(EntityTypeBuilder<TEntity> entity)
        {
            entity.Property(_ => _.CreatedAt).IsRequired();
            entity.Property(_ => _.CreatedBy).IsRequired();
            entity.Property(_ => _.UpdatedAt);
            entity.Property(_ => _.UpdatedBy);
        }
    }
}