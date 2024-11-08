using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secretsAndEquivalenceTesting
{
    public interface ICandidateFactory
    {
        Candidate CreateCandidate(string name, int age, string party, string altingetUrl);
        CandidateExtended CreateCandidateExtended(string name, int age, string party, string altingetUrl, string email);
    }

    public class CandidateFactory : ICandidateFactory
    {
        public CandidateFactory() { }

        public Candidate CreateCandidate(string name, int age, string party, string altingetUrl)
        {
            return new Candidate(name, age, party, altingetUrl);
        }

        public CandidateExtended CreateCandidateExtended(string name, int age, string party, string altingetUrl, string email)
        {
            return new CandidateExtended(name, age, party, altingetUrl, email);
        }
    }
}
