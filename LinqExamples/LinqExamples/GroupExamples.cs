using LinqExamples.Models;

namespace LinqExamples;

public class GroupExamples
{
    public IList<IGrouping<int, int>> GroupEvenAndOddNumbers(int[] numbers)
    {
        var query = from number in numbers
                    group number by number % 2 into g
                    select g;

        return query.ToList();
    }

    public IList<PersonsOfSameBirthYearGroup> GroupPersonsByBirthYear(IList<Person> persons)
    {
        var query = from person in persons
                    group person by person.BirthDate.Year into g
                    select new PersonsOfSameBirthYearGroup
                    {
                        BirthYear = g.Key,
                        Persons = g
                    };

        return query.ToList();
    }
}
