using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.ChatRepository
{
    public class ChatRepository : IChatRepository
    {
        public DataContext _context { get; set; }
        public ChatRepository (DataContext context)
        {
            _context = context;
        }


        public Chat Create(Chat Chat)
        {
            var result = _context.Add<Chat>(Chat);
            _context.SaveChanges();
            return result.Entity;
        }

        public Chat Delete(Chat Chat)
        {
            var result = _context.Remove(Chat);
            _context.SaveChanges();
            return result.Entity;
        }

        public Chat Get(int Id)
        {
            return _context.Chats.SingleOrDefault(x => x.Id == Id);
        }

        public List<Chat> GetAll()
        {
            return _context.Chats.ToList();
        }

        public Chat Update(Chat Chat)
        {
            _context.Entry(Chat).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Chat;
        }
    }
}
