using PayablesApp.AppLogic.Contracts;
using PayablesApp.Domain;

namespace PayablesApp.Infrastructure;

internal class InMemoryInvoiceRepository : IInvoiceRepository
{
    private static Random Random = new Random();

    private readonly List<Invoice> _dummyInvoices;

    public InMemoryInvoiceRepository()
    {
        _dummyInvoices = new List<Invoice>();
        for (int i = 1; i <= 5; i++)
        {
            _dummyInvoices.Add(CreateDummyInvoiceWithoutBalanceDue(i));
        }
        for (int i = 6; i <= 10; i++)
        {
            _dummyInvoices.Add(CreateDummyInvoiceWithBalanceDue(i));
        }
    }

    public IReadOnlyList<Invoice> GetAll()
    {
        return _dummyInvoices;
    }

    private Invoice CreateDummyInvoiceWithoutBalanceDue(int identifier)
    {
        return new Invoice
        {
            InvoiceId = identifier,
            InvoiceDate = DateTime.Today.AddDays(-1 * Random.Next(10, 51)),
            InvoiceNumber = $"9893-{identifier}",
            VendorId = 1,
            DueDate = DateTime.Today.AddDays(Random.Next(0,31)),
            InvoiceTotal = Random.Next(5000, 50000),
            CreditTotal = Random.Next(0, 2000),
            PaymentTotal = Random.Next(0, 10000),
            PaymentDate = DateTime.Today.AddDays(-1 * Random.Next(1, 10))
        };
    }

    private Invoice CreateDummyInvoiceWithBalanceDue(int identifier)
    {
        return new Invoice
        {
            InvoiceId = identifier,
            InvoiceDate = DateTime.Today.AddDays(-1 * Random.Next(10, 51)),
            InvoiceNumber = $"2632-{identifier}",
            VendorId = 2,
            DueDate = DateTime.Today.AddDays(-1 * Random.Next(1, 11)),
            InvoiceTotal = Random.Next(100, 30000),
            CreditTotal = Random.Next(0, 1000),
            PaymentTotal = Random.Next(0, 5000),
            PaymentDate = DateTime.Today.AddDays(-5)
        };
    }
}