using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICTProject.Models.DBC
{
    public class Positions
    {
        public int PositionsId { get; set; }
        public User UserId { get; set; }
        public int PositionLevel { get; set; }
    }
}