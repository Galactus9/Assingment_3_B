using Assingment_3_B.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Assingment_3_B.Models
{
    public class CertificateOfEachCandidate
    {
        public int Id { get; set; }
        public virtual Candidate candidate { get; set; }
        
        public virtual Certificate certificate { get; set; }
        public DateTime DateOfExamination { get; set; }
        public DateTime ScoreReportDate { get; set; }
        public ICollection<CandidateScorePerTopic> scorePerTopic { get; set; }
        public int totalScore { get; set; }
        public string Resualt { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //return $"First Name : {candidate.FirstName}\t Last Name : {candidate.LastName}\t Id : {candidate.Id}";

            sb.Append($"First Name : {candidate.FirstName}\t Last Name : {candidate.LastName} Id : {candidate.Id}");

                foreach (var scorePT in scorePerTopic)
                {
                    sb.Append($"Title : {scorePT.Title}\t Max Score : {scorePT.Score}");
                }
            return sb.ToString(); ;
        }
    }

}
