namespace BethanysPieShop.Models;

public interface IPieRepository
{
    Task<IEnumerable<Pie>> GetAllPies();
    IEnumerable<Pie> GetPiesOfTheWeek();
    Pie? GetById(int id);

    IEnumerable<Pie> SearchPies(string searchQuery);
}