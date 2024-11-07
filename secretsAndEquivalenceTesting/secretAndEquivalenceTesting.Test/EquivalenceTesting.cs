using AutoFixture;
using AutoFixture.Xunit2;
using secretsAndEquivalenceTesting;

namespace secretAndEquivalenceTesting.Test
{
    public class EquivalenceTesting
    {
        [Theory, AutoData]
        public void CreateCandidateEquivalenceTest(string name, int age, string party, string url, string email )
        {
            // arrange
            var fixture = new Fixture();

            var expected = fixture.Build<Candidate>()
                .WithAutoProperties()
                .Create();


            // act
            var actual = new CandidateFactory().CreateCandidate(name, age, party, url);
            
            // assert
            Assert.Equivalent(expected, actual, true);
            

        }
    }
}