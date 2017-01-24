using System;
using System.Web;

namespace IMS.ModelingLib.IMS.StupidParadigm
{

    public class SessionData
    {
        private static readonly Lazy<SessionData> instance = new Lazy<SessionData>(() => new SessionData());

        private string _contactName;
        private int _contactId;
        private string _currentTab;

        public string ContactName
        {
            get { _contactName = (string)HttpContext.Current.Session["_contactName_"]; return _contactName; }
            set { HttpContext.Current.Session["_contactName_"] = value; }
        }

        public int ContactId
        {
            get { _contactId = (int)HttpContext.Current.Session["_contactId_"]; return _contactId; }
            set { HttpContext.Current.Session["_contactId_"] = value; }
        }

        public string CurrentTab
        {
            get { _currentTab = (string)HttpContext.Current.Session["_currentTab_"]; return _currentTab; }
            set { HttpContext.Current.Session["_currentTab_"] = value; }
        }

        public static SessionData getInstance
        {
            get { return instance.Value; }
        }
    }
}
