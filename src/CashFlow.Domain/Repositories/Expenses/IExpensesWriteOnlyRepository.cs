using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Repositories.Expenses;
public interface IExpensesWriteOnlyRepository
{
    Task Add(Expense expense);
    /// <summary>
    /// This function returns true if the expense with the specified id was deleted successfully, and false if the expense was not found.
    /// </summary>
    /// <param name="id">The id of the expense to delete.</param>
    /// <returns>A boolean indicating whether the expense was deleted successfully. </returns>
    Task<bool> Delete(long id);
}
