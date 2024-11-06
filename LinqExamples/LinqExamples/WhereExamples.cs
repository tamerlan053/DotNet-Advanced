using LinqExamples.Models;

namespace LinqExamples;

public class WhereExamples
{
    public int[] FilterOutNumbersDivisibleByTen(int[] numbers)
    {
        var query  = from number in numbers
                     where number % 10 == 0 
                     select number;

        return query.ToArray();
    }

    public IList<Person> FilterOutPersonsThatAreEighteenOrOlder(List<Person> persons)
    {
        var query = from person in persons
                    where person.BirthDate.Year <= 18
                    select person;

        return query.ToArray();
    }
}
