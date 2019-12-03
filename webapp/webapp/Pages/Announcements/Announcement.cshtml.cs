using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp.Models;

namespace webapp.Pages
{
    public class AnnouncementModel : PageModel
    {
        public Announcements AnnounceText { get; set; }
        public string inputText { get; set; }
        public int LU { get; set; }
        public DateTime now { get; set; }
        public DateTime end { get; set;}
        public void OnGet()
        {
            Announcements temp = new Announcements();
            temp.getAnnouncements();
            AnnounceText = temp;
        }
        public void OnPost()
        {
            string loguit = Request.Form[nameof(LU)];
            if (loguit == null)
            {
                Announcements ann = new Announcements();
                ann.getAnnouncements();
                AnnounceText = ann;
                string temp = Request.Form[nameof(inputText)];
                if (temp != null && AnnounceText.announcement != null)
                {
                    AnnounceText.deleteAnnouncement();
                }
                if (temp != null)
                {
                    Announcements temp2 = new Announcements();
                    temp2.startdate = DateTime.Now;
                    temp2.enddate = DateTime.Now.AddDays(7);
                    temp2.announcement = temp;
                    temp2.insertAnnouncement();
                    Response.Redirect("/Menu/PMenu");
                }
            }
            else if(loguit != null)
            {
                Announcements ann = new Announcements();
                ann.getAnnouncements();
                AnnounceText = ann;
                AnnounceText.deleteAnnouncement();
            }
            OnGet();
        }
        
    }
}