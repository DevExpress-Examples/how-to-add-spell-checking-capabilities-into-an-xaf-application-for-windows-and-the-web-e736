using System;
using DevExpress.Xpo;
using DevExpress.Persistent.BaseImpl;

namespace WinSolution.Module {
    public class Article : BaseObject {
        public Article(Session session) : base(session) { }
        private string _description;
        [Size(SizeAttribute.Unlimited)]
        public string Description {
            get { return _description; }
            set { SetPropertyValue("Description", ref _description, value); }
        }
        private string _subject;
        public string Subject {
            get { return _subject; }
            set { SetPropertyValue("Subject", ref _subject, value); }
        }
        private Document _document;
        [Association("Document-Articles")]
        public Document Document {
            get { return _document; }
            set { SetPropertyValue("Document", ref _document, value); }
        }
        private DateTime _createdOn;
        public DateTime CreatedOn {
            get { return _createdOn; }
            set { SetPropertyValue("CreatedOn", ref _createdOn, value); }
        }
    }
}