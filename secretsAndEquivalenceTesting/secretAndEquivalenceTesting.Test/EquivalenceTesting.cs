using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;
using Moq;
using secretsAndEquivalenceTesting;
using SemanticComparison;
using SemanticComparison.Fluent;

namespace secretAndEquivalenceTesting.Test
{
    public class EquivalenceTesting
    {
        public class AutoMoqDataAttribute : AutoDataAttribute
        {
            public AutoMoqDataAttribute() : base(() =>
            {
                var fixture = new Fixture();
                fixture.Customize(new AutoMoqCustomization());
                return fixture;
            })
            { }
        }

        [Theory, AutoMoqData]
        public void CreateCandidateEquivalenceTest(
            CandidateService sut, 
            [Frozen]
            Mock<ICandidateFactory> factory, 
            Candidate expected)
        {
            factory.Setup(f => f.CreateCandidate(
                It.IsAny<string>(),
                It.IsAny<int>(),
                It.IsAny<string>(),
                It.IsAny<string>()))
                .Returns(expected);

            // arrange & act
            var actual = sut.CreateCandidate(expected.Name, expected.Age, expected.Party, expected.AltingetUrl);

            // assert
            factory.Verify(f => f.CreateCandidate(
                It.IsAny<string>(), 
                It.IsAny<int>(), 
                It.IsAny<string>(), 
                It.IsAny<string>()), Times.Once);

            Assert.Equivalent(expected, actual);
        }
    }
}