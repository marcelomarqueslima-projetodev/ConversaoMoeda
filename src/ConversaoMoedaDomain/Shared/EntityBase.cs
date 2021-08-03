using System;
using System.Collections.Generic;
using System.Text;

namespace ConversaoMoedaDomain.Shared
{
    public abstract class EntityBase
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
