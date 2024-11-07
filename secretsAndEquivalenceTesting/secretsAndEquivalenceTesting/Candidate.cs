namespace secretsAndEquivalenceTesting;

public class Candidate(string name, int age, string party, string altingetUrl)
{
}

public class CandidateExtended(string name, int age, string party, string altingetUrl, string email)
    : Candidate(name, age, party, altingetUrl)
{
    public string Email { get; } = email;
}