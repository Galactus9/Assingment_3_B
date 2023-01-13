using Assingment_3_B.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Assingment_3_B;

namespace Assingment_3_B.Data
{
    public class AppDBContext : DbContext
    {

        public virtual DbSet<Candidate> Candidate { get; set; }
        public virtual DbSet<Certificate> Certificate { get; set; }
        public virtual DbSet<CertificateOfEachCandidate> CertificateOfEachCandidate { get; set; }
        //public virtual DbSet<CandidateScorePerTopic> CandidateScorePerTopic { get; set; }
        public AppDBContext() : base("Assingment_3_B_Neoklis_Varsamos")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CertificateOfEachCandidate>().HasRequired<Candidate>(c => c.candidate).WithMany().WillCascadeOnDelete(true);
            modelBuilder.Entity<CandidateScorePerTopic>().HasRequired<Candidate>(c => c.candidate).WithMany().WillCascadeOnDelete(true);
        }


    }
}
