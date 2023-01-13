

namespace Assingment_3_B.Models
{
    public class CandidateScorePerTopic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Score { get; set; }
        public Candidate candidate { get; set; }

    public override string ToString()
    {
        return $"Topic Title : {Title}\t Topic Score : {Score}";
    }
    }
}
