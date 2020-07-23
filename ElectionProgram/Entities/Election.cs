using System;
using System.Collections.Generic;
using System.Text;

namespace ElectionProgram.Entities
{
    class Election
    {

        public string Candidates { get; set; }
        public int Votes { get; set; }

        public Election()
        {

        }

        public Election(string candidates, int votes)
        {
            Candidates = candidates;
            Votes = votes;
        }

        public override int GetHashCode()
        {
            return Candidates.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return Candidates.Equals(obj);
        }
    }
}
