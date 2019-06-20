using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        static readonly InterfaceStudentRepository repository = new StudentRepository();



        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

       
        public HttpResponseMessage PostStudent(Student  item)
        {
            item = repository.Add(item);

            var response = Request.CreateResponse<Student>(HttpStatusCode.Created, item);
            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);

            return response;
        }



    }
}