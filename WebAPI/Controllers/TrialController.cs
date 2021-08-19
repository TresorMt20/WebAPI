using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLAYER;
using System.Data.SqlClient;
using ModelLayer;
using ServiceLayer;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrialController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Cloth> GET()
        {

            //Cloth cl = new Cloth();
            Service serv = new Service();

            //serv.AddCloths(cl);

            return serv.Getcloths();
            //return new Cloth[] { serv.Getcloths(); };
        }
        [HttpPost]
        public void Save(Cloth cloth)
        {

            
            Service serv = new Service();

            serv.AddCloths(cloth);

        }
    }
}
