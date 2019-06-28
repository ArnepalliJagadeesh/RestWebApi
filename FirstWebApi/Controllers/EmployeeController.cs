using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebApi.Controllers
{
    [RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {

        [Route("GetEmployeeName")]
        //[HttpGet]
        public string GetEmployeeName()
        {
            return "jagadeesh";
        }
        [Route("GetEmployeeFirstName")]
        [HttpGet]
        public string GetEmployeeFirstName(int id)
        {
            return "Arnepalli";
        }

        
    }
}
