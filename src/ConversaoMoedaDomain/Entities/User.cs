using ConversaoMoedaDomain.DomainObjects;
using System;

namespace ConversaoMoedaDomain.Entities
{
    public class User : Entity, IAggregateRoot
    {
        public User(string nameUser)
        {
            NameUser = nameUser;

            Validar();
        }

        public string NameUser { get; set; }
        public DateTime DateRegister { get; set; } = DateTime.UtcNow;

        public void Validar()
        {
            Validacoes.ValidarSeVazio(NameUser, "O campo Nome do produto não pode estar vazio");
        }
    }
}
