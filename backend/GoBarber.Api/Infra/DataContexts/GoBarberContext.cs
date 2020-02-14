using GoBarber.Api.Domain.Users.Models;
using Microsoft.EntityFrameworkCore;

namespace GoBarber.Api.Infra.DataContexts
{
    public class GoBarberContext : DbContext
    {
        public GoBarberContext() { }
        public GoBarberContext(DbContextOptions<GoBarberContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}