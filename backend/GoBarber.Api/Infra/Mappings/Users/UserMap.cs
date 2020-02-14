using GoBarber.Api.Domain.Users.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoBarber.Api.Infra.Mappings.Users
{
    public class UserMap : EntityMap<User>
    {
        public UserMap(EntityTypeBuilder<User> entity)
            : base(entity)
        {
            entity.HasKey(_ => _.Id);

            entity.Property(_ => _.UniqueId).IsRequired();
            entity.Property(_ => _.Name).IsRequired().HasMaxLength(128).IsUnicode(false);
            entity.Property(_ => _.Email).IsRequired().HasMaxLength(128).IsUnicode(false);
            entity.Property(_ => _.Password).IsRequired().HasMaxLength(2048).IsUnicode(false);
            entity.Property(_ => _.Provider).IsRequired();
        }
    }
}