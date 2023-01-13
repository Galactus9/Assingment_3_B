using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Assingment_3_B.Models;

namespace Assingment_3_B.Data.Repository
{
    internal interface ICandidateRepository : IRepository<Candidate>
    {
    IEnumerable<CertificateOfEachCandidate> GetPassedExams(int id);

    }
}
