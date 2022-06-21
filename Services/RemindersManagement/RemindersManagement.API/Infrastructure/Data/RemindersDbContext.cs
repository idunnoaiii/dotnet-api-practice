

using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using RemindersManagement.API.Domain.Models;

namespace RemindersManagement.API.Infrastructure.Data;

public class RemindersDbContext : DbContext
{
    const string DEFAULT_SCHEMA = "reminders";

    public DbSet<Reminder> Reminders { get; set; }

    public override DatabaseFacade Database => base.Database;

    public override ChangeTracker ChangeTracker => base.ChangeTracker;

    public override IModel Model => base.Model;

    public override DbContextId ContextId => base.ContextId;

    public RemindersDbContext(DbContextOptions<RemindersDbContext> options)
        : base(options)
    {
    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Reminder>(config =>
        {
            config.ToTable("Reminders", DEFAULT_SCHEMA);
            config.HasKey(r => r.Id);
            config.Property(r => r.Description).IsRequired();
            config.Property(r => r.Status).HasColumnType("varchar(50)").IsRequired();
        });

        //Data seed
        modelBuilder.Entity<Reminder>().HasData(
            new Reminder
            {
                Id = Guid.NewGuid(),
                Description = "Learning Microservices",
                Status = ReminderStatus.Finished
            },
            new Reminder
            {
                Id = Guid.NewGuid(),
                Description = "Writing Blog",
                Status = ReminderStatus.Doing
            },
            new Reminder
            {
                Id = Guid.NewGuid(),
                Description = "Presentation prepare",
                Status = ReminderStatus.Doing
            }
        );
    }

}