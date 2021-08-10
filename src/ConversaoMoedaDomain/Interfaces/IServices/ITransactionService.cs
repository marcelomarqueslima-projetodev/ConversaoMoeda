using System;
using System.Collections.Generic;
using System.Transactions;

namespace ConversaoMoedaDomain.Interfaces.IServices
{
    public interface ITransactionService
    {
        Transaction Insert(Transaction transaction);
        Transaction Update(Transaction transaction);
        void Delete(int id);
        Transaction RecoverById(Guid id);
        IList<Transaction> Browse();
    }
}
