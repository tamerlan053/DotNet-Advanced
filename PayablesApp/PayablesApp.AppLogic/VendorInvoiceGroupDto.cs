using PayablesApp.Domain;

namespace PayablesApp.AppLogic;

public class VendorInvoiceGroupDto
{
    public int VendorId { get; set; }
    public int Count { get; set; }
    public IList<Invoice> Invoices { get; set; }

    public VendorInvoiceGroupDto()
    {
        Invoices = new List<Invoice>();
    }
}