

namespace Assingment_3_B.Models
{
    public class CertificateTopics
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public int MaxScore { get; set; }


        public override string ToString()
        {
            return $"Id : {Id}\t Title : {Title}\t Max Score : {MaxScore}";
        }
    }

}