using MDR.Web.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MDR.Web.Controllers
{
    public class ContactController : ApiController
    {
        public HttpResponseMessage Post([FromBody]ContactForm value)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent("Message sent successfully");

            return response;
        }
    }
}