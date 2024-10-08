using PayablesApp.Domain;

namespace PayablesApp.AppLogic.Contracts;

public interface IVendorRepository
{
    IReadOnlyList<Vendor> GetAll();

}