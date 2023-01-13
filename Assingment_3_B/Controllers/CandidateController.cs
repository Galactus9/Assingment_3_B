using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assingment_3_B.Data;
using Assingment_3_B.Data.Repository;
using Assingment_3_B.Models;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Web.Services.Protocols;
using System.Data.Entity;
using Assingment_3_B.Services;

namespace Assingment_3_B.Controllers
{
    public class CandidateController : Controller
    {
        static readonly AppDBContext context = new AppDBContext();
        CandidateRepository repo = new CandidateRepository(context);

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult GetCandidateId()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SeeCertificates(int id)
        {
            // Process the integer value here
            return View(repo.GetPassedExams(id));
        }

        public ActionResult ExportPDF(int id) 
        {
			PdfHandler pdf = new PdfHandler();
			var constant = pdf.GenerateCertificakePdf(id);
			return File(constant, "application/void", "ItsPDF.pdf");

			

		}


    }
}