using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace saf_kaizala_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductRegistrationController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post()
        {
            string body = string.Empty;
            using (var reader = new StreamReader(this.Request.Body))
            {
                body = reader.ReadToEnd();
            }

            dynamic obj = JsonConvert.DeserializeObject(body);
            dynamic responses = obj.data.responseDetails.responseWithQuestions;

            //check if customer details exist, if so, load from db & save product details
            
            var customer = new Models.Customer(
                (string)responses[0].answer, 
                (string)responses[1].answer, 
                (string)responses[2].answer,
                (string)responses[3].answer,
                (string)responses[4].answer.cc + (string)responses[4].answer.pn);
            var senderInfo = new Models.Sender()
            {
                Id = obj.fromUserId,
                Name = obj.fromUserName,
                PhoneNumber = obj.fromUser
            };
            var registration = new Models.ProductRegistration(
                (string)responses[5].answer[0], 
                (string)responses[6].answer[0],
                (double?)responses[7].answer.lt,
                (double?)responses[7].answer.lg,
                (string)responses[7].answer.n,
                senderInfo,
                (string)obj.data.responseId,
                customer.Id
            );
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
