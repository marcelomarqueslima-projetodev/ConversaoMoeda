using ConversaoMoedaDomain.Entities;
using System;
using System.Collections.Generic;

namespace ConversaoMoedaDomain.Interfaces.IRepositories
{
    public interface IUser
    {
        void Save(User user);
        void Remove(Guid id);
        User GetById(Guid id);
        IList<User> GetAll();
    }
}
