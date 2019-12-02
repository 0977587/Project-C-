using DatabaseController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Models
{
    public class Announcements
    {
        public Announcements(string announcement, DateTime startdate, DateTime enddate)
        {
            this.announcement = announcement;
            this.startdate = startdate;
            this.enddate = enddate;
        }

        public Announcements()
        {
        }

        public String announcement { get; set; }

        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }

        public void insertAnnouncement()
        {
            DateTime right = DateTime.UtcNow;
            new DBConnection().Send("INSERT `projectcdb`.`announcements` SET `announcement` = '" + announcement + "',`startdate` = STR_TO_DATE('" + right + "','%d/%m/%Y %H:%i:%s'), `enddate` = STR_TO_DATE('" + enddate + "','%d/%m/%Y %H:%i:%s')");
        }
        public void deleteAnnouncement()
        {
            new DBConnection().Send("DELETE FROM `projectcdb`.`announcements` WHERE announcement = '" + announcement + "' ;");
        }

        public Announcements getAnnouncements()
        {
            DateTime right = DateTime.UtcNow;
            List<List<string>> temp = new DBConnection().Send("SELECT * FROM projectcdb.announcements");
            if (temp.Count != 0)
            {
                if (temp[0][0] != "")
                    announcement = temp[0][0];
                if (temp[0][1] != "")
                    startdate = Convert.ToDateTime(temp[0][1]);
                if (temp[0][2] != "")
                    enddate = Convert.ToDateTime(temp[0][2]);
                return new Announcements(announcement,startdate,enddate);
            }
            else
            {
                return new Announcements();
            }
        }
    }
}
