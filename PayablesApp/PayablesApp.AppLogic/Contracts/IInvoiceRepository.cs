using PayablesApp.Domain;

namespace PayablesApp.AppLogic.Contracts;

public interface IInvoiceRepository
{
    IReadOnlyList<Invoice> GetAll();
}