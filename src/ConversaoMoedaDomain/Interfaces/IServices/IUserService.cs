using ConversaoMoedaDomain.Entities;
using System;
using System.Collections.Generic;

namespace ConversaoMoedaDomain.Interfaces.IServices
{
    public interface IUserService
    {
        User Insert(User user);
        User Update(User user);
        void Delete(int id);
        User RecoverById(Guid id);
        IList<User> Browse();
    }
}
