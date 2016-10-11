using System;
using System.Collections.Generic;

namespace Mocking
{
    public class MailBox
    {
        public List<Mail> MailList;
        public MailBox()
        {
            MailList = new List<Mail>();
        }

        public int NumReceivedMessages {
            get
            { return MailList.Count; }
            set
            { }
        }


        internal void Add(Mail o)
        {
           MailList.Add(o) ;
        }

        internal string GetLatestMessageText()
        {
            Mail m = MailList[MailList.Count - 1];
            return m.Content;
        }
    }
}