using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.ChatRepository
{
    interface IChatRepository
    {
        List<Chat> GetAll();
        Chat Get(int Id);
        Chat Create(Chat Chat);
        Chat Update(Chat Chat);
        Chat Delete(Chat Chat);
    }
}
