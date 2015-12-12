using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerApp.Models
{
    public class BugListViewModel
    {
        public IEnumerable<Bug> Bugs { get; set; }
        public int Total { get; set; }
        public int ClosedCount { get; set; }
    }
}