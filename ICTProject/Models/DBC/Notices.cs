using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICTProject.Models.DBC
{
    public class Notices
    {
        public int NoticesId { get; set; }
        public DateTime Date { get; set; }
        public User UserId { get; set; }
        public string Message { get; set; }
        public Region RegionId { get; set; }
    }
}