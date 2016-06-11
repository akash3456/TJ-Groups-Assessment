using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuestionServiceWebApi.Interfaces;

namespace QuestionServiceWebApi.Controllers
{
    public class AnswerController : ApiController
    {
        private readonly IAnswerRepository _ianswer_repo;

        public AnswerController(IAnswerRepository _answers) {

            _ianswer_repo = _answers;
        }

        public AnswerController() : this(new AnswerRepository()) {

        }
        // GET api/answer
        public Answer Get()
        {
            return _ianswer_repo.GetAnswer();
        }

        // GET api/answer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/answer
        public void Post([FromBody]string value)
        {
        }

        // PUT api/answer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/answer/5
        public void Delete(int id)
        {
        }
    }
}
