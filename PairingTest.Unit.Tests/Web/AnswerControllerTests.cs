using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PairingTest.Web.Controllers;
using PairingTest.Web.Models;


namespace PairingTest.Unit.Tests.Web
{
    [TestFixture]
       public class AnswerControllerTests
    {
        [Test]
        public void ShouldGetAnswers() {

            var expectedTitle = "My expected Answers";
            var answers_controller = new AnswerController();
            var result = (AnswerViewModel)answers_controller.Index().ViewData.Model;

            Assert.That(result.AnswerTitle, Is.EqualTo(expectedTitle));
        }

        [Test]
        public void ShouldGetAnswer_Content() {

            var expected_answer = "Cuba";
            var controller = new AnswerController();

            var result = (AnswerViewModel)controller.Index().ViewData.Model;

            Assert.That(result.AnswerText, Is.EqualTo(expected_answer));
        }

    }
}
