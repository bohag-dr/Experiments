using secretsAndEquivalenceTesting;

namespace secretAndEquivalenceTesting.Test
{
    public class EquivalenceTesting
    {
        [Fact]
        public void CreateCandidateEquivalenceTest()
        {
            // arrange
            var factory = CandidateFactory(out var name, out var age, out var party, out var altingetUrl, out var email);
            var expected = new Candidate(name, age, party, altingetUrl);

            // act
            var actual = factory.CreateCandidate(name, age, party, altingetUrl);
            var actualExtended = factory.CreateCandidateExtended(name, age, party, altingetUrl, email);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equivalent(expected, actual, true);
            Assert.Equivalent(expected, actual, false);

        }

        private static CandidateFactory CandidateFactory(out string name, out int age, out string party, out string altingetUrl,
            out string email)
        {
            var factory = new CandidateFactory();
            name = "John Doe";
            age = 42;
            party = "The Party";
            altingetUrl = "http://example.com";
            email = "john@doe.dk";
            return factory;
        }
    }
}