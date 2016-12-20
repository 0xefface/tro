using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Base;

namespace RealmOffline.Core
{
    public class MagicMail
    {
        public int SqlID { get; private set; }
        public Account Player { get; private set; }
        public List<Mail> AllMail { get; set; }

        public int NextMailID
        {
            get
            {
                if (AllMail == null)
                    return 0;
                List<int> used = new List<int>();

                foreach (Mail m in AllMail)
                    used.Add(m.MailID);

                return Enumerable.Range(1, short.MaxValue - 1).Except(used).ToArray()[0];
            }
        }
        public MagicMail(Account acct)
        {
            this.Player = acct;
            this.AllMail = new List<Mail>();
            this.RefreshMail();
        }
        public void RefreshMail()
        {
            if (this.AllMail != null) this.AllMail.Clear();

            this.AllMail = Managers.MySqlManager.LoadMail(this.Player.CurrentCharacter.SqlCharId);
        }
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
        public static double DateTimeToUnixTimestamp(DateTime dateTime)
        {
            return (dateTime - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
        }
    }
}
public class Mail
{
    public int MailID { get; set; }
    public int TimeStamp { get; set; }
    public string Subject { get; set; }
    public string From { get; set; }
    public string Body { get; set; }
}