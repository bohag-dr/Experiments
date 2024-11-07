namespace secretsAndEquivalenceTesting;

public record Candidate(string name, int age, string party, string altingetUrl)
{
}

public record CandidateExtended(string name, int age, string party, string altingetUrl, string email)
    : Candidate(name, age, party, altingetUrl)
{
    public string Email { get; } = email;
}