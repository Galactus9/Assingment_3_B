namespace Assingment_3_B.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        MidleName = c.String(),
                        Gender = c.String(),
                        NativeLanguage = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        PhotoIdType = c.String(),
                        PhotoIdNumber = c.String(),
                        PhotoIdIssueDate = c.DateTime(nullable: false),
                        Email = c.String(),
                        Address = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        Region = c.String(),
                        PostalCode = c.String(),
                        Country = c.String(),
                        LandlineNumber = c.String(),
                        MobileNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Certificates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ScoreNeededToPass = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CertificateTopics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        MaxScore = c.Int(nullable: false),
                        Certificate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Certificates", t => t.Certificate_Id)
                .Index(t => t.Certificate_Id);
            
            CreateTable(
                "dbo.CertificateOfEachCandidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfExamination = c.DateTime(nullable: false),
                        ScoreReportDate = c.DateTime(nullable: false),
                        totalScore = c.Int(nullable: false),
                        Resualt = c.String(),
                        candidate_Id = c.Int(nullable: false),
                        certificate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.candidate_Id, cascadeDelete: true)
                .ForeignKey("dbo.Certificates", t => t.certificate_Id)
                .Index(t => t.candidate_Id)
                .Index(t => t.certificate_Id);
            
            CreateTable(
                "dbo.CandidateScorePerTopics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Score = c.Int(nullable: false),
                        candidate_Id = c.Int(nullable: false),
                        CertificateOfEachCandidate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.candidate_Id, cascadeDelete: true)
                .ForeignKey("dbo.CertificateOfEachCandidates", t => t.CertificateOfEachCandidate_Id)
                .Index(t => t.candidate_Id)
                .Index(t => t.CertificateOfEachCandidate_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CandidateScorePerTopics", "CertificateOfEachCandidate_Id", "dbo.CertificateOfEachCandidates");
            DropForeignKey("dbo.CandidateScorePerTopics", "candidate_Id", "dbo.Candidates");
            DropForeignKey("dbo.CertificateOfEachCandidates", "certificate_Id", "dbo.Certificates");
            DropForeignKey("dbo.CertificateOfEachCandidates", "candidate_Id", "dbo.Candidates");
            DropForeignKey("dbo.CertificateTopics", "Certificate_Id", "dbo.Certificates");
            DropIndex("dbo.CandidateScorePerTopics", new[] { "CertificateOfEachCandidate_Id" });
            DropIndex("dbo.CandidateScorePerTopics", new[] { "candidate_Id" });
            DropIndex("dbo.CertificateOfEachCandidates", new[] { "certificate_Id" });
            DropIndex("dbo.CertificateOfEachCandidates", new[] { "candidate_Id" });
            DropIndex("dbo.CertificateTopics", new[] { "Certificate_Id" });
            DropTable("dbo.CandidateScorePerTopics");
            DropTable("dbo.CertificateOfEachCandidates");
            DropTable("dbo.CertificateTopics");
            DropTable("dbo.Certificates");
            DropTable("dbo.Candidates");
        }
    }
}
