using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Assingment_3_B.Models;

namespace Assingment_3_B.Data.Repository
{
    public class CerificateRepository : GenericRepository<Certificate>, ICerificateRepository
    {
        public CerificateRepository(AppDBContext context) : base(context)
        {

        }
    }
}