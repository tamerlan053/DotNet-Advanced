using LinqExamples.Models;

namespace LinqExamples;

public class OrderByExamples
{
    public double[] SortAnglesFromBigToSmall(double[] angles)
    {
        var query = from angle in angles
                    orderby angle ascending
                    select angle;

        return query.ToArray();
    }

    public IList<Person> SortPersonsFromYoungToOldAndThenOnNameAlphabetically(List<Person> persons)
    {
        throw new NotImplementedException("Use LINQ to implement this method");
    }
}
