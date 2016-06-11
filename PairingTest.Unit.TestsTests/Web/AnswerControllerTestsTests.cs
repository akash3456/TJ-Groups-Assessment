using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairingTest.Unit.Tests.Web;
using PairingTest.Web.Controllers;
using PairingTest.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc.Ajax;

namespace PairingTest.Unit.Tests.Web.Tests
{
    [TestClass()]
    public class AnswerControllerTestsTests
    {
        [TestMethod()]
        public void ShouldGetAnswers()
        {

            var expectedTitle = "My expected Answers";
            var answers_controller = new AnswerController();

            System.Net.WebRequest request = System.Net.WebRequest.Create("http://localhost:49852/api/questions");
            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream datastream = response.GetResponseStream();
            StreamReader str = new StreamReader(datastream);
            string read_resp = str.ReadToEnd();
            str.Close();
            response.Close();
            
            string[] split = read_resp.Split(',');
            var title = String.Empty;
            foreach (var te in split)
            {
                var fin_string = te.Replace("{", "").Replace("}", "").Replace("]", "").Replace("[", "").
                    Replace("\"\"", "").Replace("\"", "");
                title +=  fin_string;
            }
            Assert.AreEqual(title, expectedTitle);
        }
    }
}