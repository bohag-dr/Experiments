using AutoFixture;
using AutoFixture.Xunit2;
using secretsAndEquivalenceTesting;
using SemanticComparison;
using SemanticComparison.Fluent;

namespace secretAndEquivalenceTesting.Test
{
    public class EquivalenceTesting
    {
        [Theory, AutoData]
        public void CreateCandidateEquivalenceTest(string name, int age, string party, string url, string email )
        {
            // arrange
            var fixture = new Fixture();

            var candidate = fixture.Build<Candidate>().WithAutoProperties();
            var expected = candidate.AsSource().OfLikeness<Candidate>();


            // act
            var actual = new CandidateFactory().CreateCandidate(name, age, party, url);
            
            // assert
            expected.ShouldEqual(actual);

            Assert.Equivalent(expected, actual, true);
        }
    }
}