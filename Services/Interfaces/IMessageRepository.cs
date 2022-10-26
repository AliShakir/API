using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Helpers;
using API.Entities;
using API.DTOs;

namespace API.Services.Interfaces
{
    public interface IMessageRepository
    {
        void AddMessage (Message message);
        void DeleteMessage (Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<MessageDto>> GetMessageThread(string currentUsername, string receipentUsername);
        Task<bool> SaveAllAsync();
    }
}