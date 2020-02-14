using System;

namespace GoBarber.Api.Domain.Common
{
    public abstract class Entity<TEntity> : IEntity<TEntity>
        where TEntity: class
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}