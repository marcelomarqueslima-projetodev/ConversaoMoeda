using ConversaoMoedaDomain.Enum;
using ConversaoMoedaDomain.Shared;
using System;

namespace ConversaoMoedaDomain.Entities
{
    public class Transaction : EntityBase
    {
        public int OriginCurrency { get; set; } = (int)CurrencyEnum.BRL;
        public decimal SourceValue { get; set; }
        public int DestinationCurrency { get; set; } = (int)CurrencyEnum.USD;
        public decimal ConvertRate { get; set; }
        public DateTime ConversionDate { get; set; }

        public User UserId { get; set; }
    }
}
