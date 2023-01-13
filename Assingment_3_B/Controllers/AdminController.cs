using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assingment_3_B.Data;
using Assingment_3_B.Data.Repository;
using Assingment_3_B.Models;

namespace Assingment_3_B.Controllers
{
    public class AdminController : Controller
    {
        static readonly AppDBContext context = new AppDBContext();
        CandidateRepository repo = new CandidateRepository(context);
        
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListOfCandidates() 
        {
            return View(context.Candidate);
        }
		public ActionResult Create(Candidate candidate)
        {
            return View();
        }
		public ActionResult Edit(int id)
        {
            return View(repo.Get(id));
        }
        public ActionResult Details(int id) 
        {
            return View(repo.Get(id));
        }
        public ActionResult Delete(int id)
        {
				return View(repo.Get(id));
		}
        public ActionResult Remove(int id)
        {
            repo.Delete(id);
            return RedirectToAction("ListOfCandidates");
        }
		public ActionResult Save(Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                repo.Add(candidate);
                return RedirectToAction("ListOfCandidates");
            }
            else return Redirect(Request.UrlReferrer.ToString());
		}

        public ActionResult ExamResult()
        {
            return View(context.CertificateOfEachCandidate);
        }
    }
}