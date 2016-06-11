using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PairingTest.Web.Models
{
    public class AnswerViewModel
    {
        public string AnswerText { get; set; }
        public IList<string> AnswerTitle { get; set; }
    }
}