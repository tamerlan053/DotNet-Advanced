namespace PayablesApp.AppLogic;

public class InvoiceBalanceDto
{
    public string InvoiceNumber { get; set; } = string.Empty;
    public decimal BalanceDue { get; set; }
    public decimal BalanceDone { get; set; }
}