namespace PayablesApp.AppLogic;

public class InvoiceDto
{
    public string VendorName { get; set; } = string.Empty;
    public string InvoiceNumber { get; set; } = string.Empty;
    public decimal InvoiceTotal { get; set; }
}