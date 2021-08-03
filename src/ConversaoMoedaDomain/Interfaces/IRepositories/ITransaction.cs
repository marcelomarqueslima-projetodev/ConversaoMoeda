using System;
using System.Collections.Generic;
using System.Transactions;

namespace ConversaoMoedaDomain.Interfaces.IRepositories
{
    public interface ITransaction
    {
        void Save(Transaction transaction);
        void Remove(Guid id);
        Transaction GetById(Guid id);
        IList<Transaction> GetAll();
    }
}
