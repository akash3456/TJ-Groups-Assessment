using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public class Answer
{
        [DataMember]
        public string AnswerTitle { get; set; }

        [DataMember]
        public IList<string> AnswerText { get; set; }
}
