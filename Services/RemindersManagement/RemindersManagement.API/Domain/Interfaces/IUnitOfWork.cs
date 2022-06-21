namespace RemindersManagement.API.Domain.Interfaces;

public interface IUnitOfWork
{
    IRemindersRepository RemindersRepository {get;}
    Task CommitAsync();
    Task RollbackAsync();
}