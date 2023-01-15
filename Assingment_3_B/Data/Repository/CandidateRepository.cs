using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Assingment_3_B.Models;

namespace Assingment_3_B.Data.Repository
{
    public class CandidateRepository : GenericRepository<Candidate>, ICandidateRepository 
    {
        public CandidateRepository(AppDBContext context) : base(context)
        {
        }

        public IEnumerable<CertificateOfEachCandidate> GetPassedExams(int? candidateId)
        {
            if (candidateId > 0)
            {
                return Context.CertificateOfEachCandidate.Where(x => x.Resualt == "Pass" && x.candidate.Id == candidateId).ToList();
            }
            return Enumerable.Empty<CertificateOfEachCandidate>();
        }
        public CertificateOfEachCandidate GetExam(int id)
        {
            return Context.CertificateOfEachCandidate.Where(x => x.Id == id).Include(x => x.scorePerTopic).Include(x => x.certificate.CertificateTopics).FirstOrDefault();
		}

    }
}