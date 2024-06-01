namespace Specification_C_
{
    public class AgeSpecification : ISpecification<Person>
    {
        private int _minAge;
        private int _maxAge;

        public AgeSpecification(int minAge, int maxAge)
        {
            _minAge = minAge;
            _maxAge = maxAge;
        }

        public bool IsSatisfiedBy(Person candidate)
        {
            return candidate.Age >= _minAge && candidate.Age <= _maxAge;
        }
    }
}
