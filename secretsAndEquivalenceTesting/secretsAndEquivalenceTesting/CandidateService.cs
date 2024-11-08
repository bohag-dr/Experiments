using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secretsAndEquivalenceTesting
{
    public class CandidateService
    {
        private readonly ICandidateFactory _factory;
        public CandidateService(ICandidateFactory _factory)
        {
            this._factory = _factory;
        }

        public Candidate CreateCandidate(string name, int age, string party, string altingetUrl)
        {
            return _factory.CreateCandidate(name, age, party, altingetUrl);
        }
    }
}
