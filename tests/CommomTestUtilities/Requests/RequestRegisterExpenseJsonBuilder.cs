using Bogus;
using CashFlow.Communication.Requests;

namespace CommomTestUtilities.Requests;

public class RequestRegisterExpenseJsonBuilder
{
    public static RequestExpenseJson Build()
    {
        return new Faker<RequestExpenseJson>()
            .RuleFor(r => r.Title, f => f.Commerce.Product())
            .RuleFor(r => r.Description, f => f.Commerce.ProductDescription())
            .RuleFor(r => r.Date, f => f.Date.Past())
            .RuleFor(r => r.Amount, f => f.Finance.Amount(1, 1000))
            .RuleFor(r => r.PaymentType, f => f.PickRandom<CashFlow.Communication.Enums.PaymentType>());

    }
}
