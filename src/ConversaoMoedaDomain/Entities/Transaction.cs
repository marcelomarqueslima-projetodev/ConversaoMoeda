using ConversaoMoedaDomain.DomainObjects;
using ConversaoMoedaDomain.Enum;
using System;

namespace ConversaoMoedaDomain.Entities
{
    public class Transaction : Entity, IAggregateRoot
    {
        public Transaction(int originCurrency, decimal sourceValue, int destinationCurrency, decimal convertRate, DateTime conversionDate, User userId)
        {
            OriginCurrency = originCurrency;
            SourceValue = sourceValue;
            DestinationCurrency = destinationCurrency;
            ConvertRate = convertRate;
            ConversionDate = conversionDate;
            UserId = userId;
        }

        public int OriginCurrency { get; set; } = (int)CurrencyEnum.BRL;
        public decimal SourceValue { get; set; }
        public int DestinationCurrency { get; set; } = (int)CurrencyEnum.USD;
        public decimal ConvertRate { get; set; }
        public DateTime ConversionDate { get; set; }

        public User UserId { get; set; }
    }
}
