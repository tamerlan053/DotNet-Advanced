using PayablesApp.Domain;

namespace PayablesApp.AppLogic.Contracts;

public interface IInvoiceService
{
    IList<Invoice> GetBigInvoices();
    decimal GetInvoicesTotal();
    IList<InvoiceBalanceDto> GetInvoicesDue();
    IList<InvoiceDto> GetBigInvoices2();
    IList<VendorInvoiceGroupDto> GetGroupedInvoices();
}