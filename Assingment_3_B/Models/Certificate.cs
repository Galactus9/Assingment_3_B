using System.Collections.Generic;
using System.ComponentModel;

namespace Assingment_3_B.Models
{
    public class Certificate
    {
        [DisplayName("Certificate Id")]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<CertificateTopics> CertificateTopics { get; set; }
        public int ScoreNeededToPass { get; set; }
    }


}
