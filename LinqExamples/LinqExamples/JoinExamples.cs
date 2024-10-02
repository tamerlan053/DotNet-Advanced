using LinqExamples.Models;

namespace LinqExamples;

public class JoinExamples
{
    public int[] GetEvenNumbersOfIntersection(int[] firstList, int[] secondList)
    {
        var evenNumbersQuery = from number1 in firstList
                               join number2 in secondList on number1 equals number2
                               where number1 % 2 == 0
                               select number1;

        return evenNumbersQuery.ToArray();
    }

    public IList<string> MatchPersonsOnBirthMonth(IList<Person> group1, IList<Person> group2)
    {
        var matchPersonsQuery = from person1 in group1
                                 join person2 in group2 on person1.BirthDate.Month equals person2.BirthDate.Month
                                 select $"{person1.Name} and {person2.Name}";

        return matchPersonsQuery.ToArray();
    }
}
