using LinqExamples.Models;

namespace LinqExamples
{
    public class SelectExamples
    {
        public IList<int> GetLengthOfWords(IEnumerable<string?> words)
        {
            List<int> lengths = new List<int>();

            var query = words.Select(word =>
            {
                if (word == null)
                {
                    return 0;
                }
                else
                {
                    return word.Length;
                }
            });
            return query.ToList();
        }

        public IList<AngleInfo> ConvertAnglesToAngleInfos(IEnumerable<double> anglesInDegrees)
        {
            throw new NotImplementedException("Use LINQ to implement this method");
        }
    }
}
