using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RemindersManagement.API.Domain.Interfaces;
using RemindersManagement.API.Domain.Models;

namespace RemindersManagement.API.Domain.Services
{
    public interface IRemindersService
    {
        Task<IEnumerable<Reminder>> GetRemindersAsync();
        Task<Reminder> GetReminderAsync(Guid id);
        Task<Reminder> PutReminderAsync(Reminder reminder);
        Task<Reminder> DeleteReminder(Guid id);
        Task<Reminder> PutReminderAsync(Guid id, Reminder reminder);
    }

    public class RemindersService : IRemindersService
    {
        private readonly IRemindersRepository _remindersRepository;

        public RemindersService(IRemindersRepository reminderRepository)
        {
            _remindersRepository = reminderRepository;
        }

        public async Task<IEnumerable<Reminder>> GetRemindersAsync()
        {
            return await _remindersRepository.ListAsync();
        }

        public async Task<Reminder> GetReminderAsync(Guid id)
        {
            return await _remindersRepository.FindAsync(id);
        }

        public async Task<Reminder> PutReminderAsync(Reminder reminder)
        {
            // Not implement yet
            return await _remindersRepository.AddAsync(reminder);
        }

        public Task<Reminder> DeleteReminder(Guid id)
        {
            // Not implement yet
            throw new NotImplementedException();
        }

        public Task<Reminder> PutReminderAsync(Guid id, Reminder reminder)
        {
            // Not implement yet
            throw new NotImplementedException();
        }
    }
}